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
        string _pol;
        string _group;
        public Form2(string pol, string group)
        {
            InitializeComponent();
            _pol = pol;
            _group = group;
        }
        List<string> _users = new List<string> { };
        List<string> _users_id = new List<string> { };
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            vivod.Enabled = false;
        }
        private void vivod_Click(object sender, EventArgs e)
        {
            pole.Clear();
            var API_group = new VkApi();
            var API_user = new VkApi();
            int count = 0;
            string _user;

            if (druz.Checked == true)
            {
                count = 0;
                API_user.Authorize(new ApiAuthParams  
                { AccessToken = _pol });
                var friend = API_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
                {
                    Fields = VkNet.Enums.Filters.ProfileFields.All
                });

                foreach (User user in friend)
                {
                    _user = Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName + " " + user.LastName + "\r\n"));
                    pole.Text += _user;
                    _users.Add(_user);
                    _users_id.Add(user.Id.ToString());
                    count++;
                }
            }
            if (uch.Checked == true)
            {
                count = 0;
                API_group.Authorize(new ApiAuthParams    
                { AccessToken = _group });
                var follow = API_group.Groups.GetMembers(new GroupsGetMembersParams()
                {
                    GroupId = "205674020",
                    Fields = VkNet.Enums.Filters.UsersFields.FirstNameAbl
                });
                var groups = API_group.Groups.GetById(null, null, null);
                var dg = groups[0];
                MessageBox.Show(dg.ToString());
                foreach (User user in follow)
                {
                    _user = Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName + " " + user.LastName + "\r\n"));
                    pole.Text += _user;
                    _users.Add(_user);
                    count++;
                }
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
            Form3 fr3 = new Form3(_pol, _group, _users, _users_id);
            this.Hide();
            fr3.Show();
        }
    }
}
