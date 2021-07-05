using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace Progect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string getAuthForUser()
        {
            string fileName = @"token.txt";
            string token = "";
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    sr.ReadLine();
                    token = sr.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return token;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var api_group = new VkApi();
            // обработать исключения!
            api_group.Authorize(new ApiAuthParams
            {
                AccessToken = getAuthForUser()
            }); ;

            // получит запись со стены (для пользователя)
            var api_user = new VkApi();
            // обработать исключения!
            api_user.Authorize(new ApiAuthParams
            {
                AccessToken = getAuthForUser()
            });

            // получить список подписчиков сообщества (для сообщества)
            var getFollowers = api_group.Groups.GetMembers(new GroupsGetMembersParams()
            {
                GroupId = "205575031",
                Fields = VkNet.Enums.Filters.UsersFields.FirstNameAbl
            });
            foreach (User user in getFollowers)
                Console.WriteLine(user.FirstName);

            // получить список друзей(для пользователя)
            var getFriends = api_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
            {
                Fields = VkNet.Enums.Filters.ProfileFields.All
            });
            foreach (User user in getFriends)
                Console.WriteLine(user.FirstName);


            var get = api_user.Wall.Get(new WallGetParams());
            foreach (var wallPosts in get.WallPosts)
                Console.WriteLine(Encoding.Default.GetString(Encoding.UTF8.GetBytes(wallPosts.Text)));
        }
    }
}
