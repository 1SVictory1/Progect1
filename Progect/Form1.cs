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
            
            button1.Enabled = false;
            
        }
        Form2 fr2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (pol.Checked == true)
            {
                var API_user = new VkApi();
                try
                {
                    API_user.Authorize(new ApiAuthParams
                    { AccessToken = Autoriz.getAuthForUser() });
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
                    { AccessToken = Autoriz.getAuthForGroups() });
                }
                catch (Exception r)
                {
                    Console.WriteLine(r.Message);
                }

                this.Hide();
                fr2.Show();
            }
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

