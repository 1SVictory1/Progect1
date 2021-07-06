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
        string f1_pol;
        string f1_group;
        public Form2(string pol, string group)
        {
            InitializeComponent();
            f1_pol = pol;
            f1_group = group;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vivod.Enabled = false;
        }
        Autoriz aut = new Autoriz();

        private void vivod_Click(object sender, EventArgs e)
        {
            pole.Clear();
            var API_group = new VkApi();
            var API_user = new VkApi();
            int user_count = 0;
            int group_count = 0;
            int count = 0;

            if (druz.Checked == true)
            {
                
                API_user.Authorize(new ApiAuthParams  
                { AccessToken = Autoriz.getAuthForUser() });
                var friend = API_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
                {
                    Fields = VkNet.Enums.Filters.ProfileFields.All
                });
                foreach (User user in friend)
                {
                    pole.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName + " " + user.LastName + "\r\n"));
                    user_count++;
                }     
            }
            if (uch.Checked == true)
            {
                API_group.Authorize(new ApiAuthParams    
                { AccessToken = Autoriz.getAuthForGroups() });
                var follow = API_group.Groups.GetMembers(new GroupsGetMembersParams()
                {
                    GroupId = "205674020",
                    Fields = VkNet.Enums.Filters.UsersFields.FirstNameAbl
                });
                foreach (User user in follow)
                {
                    pole.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName + " " + user.LastName + "\r\n"));
                    user_count++;
                }
            }
            count = user_count + group_count;
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
            Form3 fr3 = new Form3();
            this.Hide();
            fr3.Show();
        }
    }
}
