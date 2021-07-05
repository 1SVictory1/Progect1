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
using RegPar = VkNet.Model.RequestParam; 

namespace Progect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vivod.Enabled = false;
        }
        Autoriz aut = new Autoriz();
        Form3 fr3 = new Form3();
        private void vivod_Click(object sender, EventArgs e)
        {
            pole.Items.Clear();
            var API_group = new VkApi();
            var API_user = new VkApi();
           
            if (druz.Checked == true)
            {
                
                API_user.Authorize(new ApiAuthParams  // Сань, разберись, почему не считывает
                { AccessToken = aut.getAuthForUser() });
                var friend = API_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
                {
                    Fields = VkNet.Enums.Filters.ProfileFields.All
                });
                foreach (User user in friend)
                    pole.Items.Add(Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName + " " + user.LastName)));
            }
            if (uch.Checked == true)
            {
                API_group.Authorize(new ApiAuthParams    // Тут тоже
                { AccessToken = aut.getAuthForGroups() });
                var follow = API_group.Groups.GetMembers(new GroupsGetMembersParams()
                {
                    GroupId = "204387665",
                    Fields = VkNet.Enums.Filters.UsersFields.FirstNameAbl
                });
                foreach (User user in follow)
                    pole.Items.Add(Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName + " " + user.LastName)));
            }
        }

        private void druz_CheckedChanged(object sender, EventArgs e)
        {
            if (uch.Checked == true || druz.Checked == true)
            {
                vivod.Enabled = true;
            }
            else vivod.Enabled = false;
        }

        private void uch_CheckedChanged(object sender, EventArgs e)
        {
            if ((uch.Checked == true || druz.Checked == true))
            {
                vivod.Enabled = true;
            }
            else vivod.Enabled = false;
        }

        private void dalee_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr3.Show();
        }
    }
}
