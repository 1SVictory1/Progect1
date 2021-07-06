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
            pol.Checked = true;
            button1.Enabled = false;
            grupp.Checked = false;
        }
                    Form2 fr2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            Autoriz aut = new Autoriz();
            if (pol.Checked == true)
            {
                var API_user = new VkApi();
                try
                {
                    API_user.Authorize(new ApiAuthParams
                    { AccessToken = aut.getAuthForUser()});
                }
                catch (Exception r)
                {
                    Console.WriteLine(r.Message);
                }
                this.Hide();
                fr2.Show();
            }
            else if (grupp.Checked == true)
            {
                var API_group = new VkApi();
                try
                {
                    API_group.Authorize(new ApiAuthParams
                    { AccessToken = aut.getAuthForGroups() });
                }
                catch (Exception r)
                {
                    Console.WriteLine(r.Message);
                }

                this.Hide();
                fr2.Show();

            }

            //var api_group = new VkApi();
            //// обработать исключения!
            //api_group.Authorize(new ApiAuthParams
            //{
            //    AccessToken = getAuthForUser()
            //}); ;

            //// получит запись со стены (для пользователя)
            //var api_user = new VkApi();
            //// обработать исключения!
            //api_user.Authorize(new ApiAuthParams
            //{
            //    AccessToken = getAuthForUser()
            //});

            //// получить список подписчиков сообщества (для сообщества)
            //var getFollowers = api_group.Groups.GetMembers(new GroupsGetMembersParams()
            //{
            //    GroupId = "205575031",
            //    Fields = VkNet.Enums.Filters.UsersFields.FirstNameAbl
            //});
            //foreach (User user in getFollowers)
            //    Console.WriteLine(user.FirstName);

            //// получить список друзей(для пользователя)
            //var getFriends = api_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
            //{
            //    Fields = VkNet.Enums.Filters.ProfileFields.All
            //});
            //foreach (User user in getFriends)
            //    Console.WriteLine(user.FirstName);


            //var get = api_user.Wall.Get(new WallGetParams());
            //foreach (var wallPosts in get.WallPosts)
            //    Console.WriteLine(Encoding.Default.GetString(Encoding.UTF8.GetBytes(wallPosts.Text)));
        }

        private void sogl_CheckedChanged(object sender, EventArgs e)
        {
            if ((pol.Checked == true || grupp.Checked == true) & sogl.Checked == true)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }
    }
}

