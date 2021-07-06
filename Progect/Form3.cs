using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace Progect
{
    public partial class Form3 : Form
    {
        string f2_pol;
        string f2_group;
        public Form3(string pol, string group)
        {
            InitializeComponent();
            f2_pol = pol;
            f2_group = group;
        }
        Form2 fr2 = new Form2();


        private void nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var API_user = new VkApi();
            API_user.Authorize(new ApiAuthParams
            { AccessToken = f2_pol });
            var Wall = API_user.Wall.Get(new WallGetParams
            {
                OwnerId = 379204040,
                Extended = true,
                Count = 1
            });
            foreach (VkNet.Model.Attachments.Post Post in Wall.WallPosts)
            {
                textBox1.Text += $"Пост от {Post.Date}, Просмотров: {Post.Views.Count}, \r\n \r\n";
                textBox1.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(Post.Text)) + "\r\n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var API_group = new VkApi();
            API_group.Authorize(new ApiAuthParams
            { AccessToken = f2_group });
            var Wall = API_group.Wall.Get(new WallGetParams
            {
                OwnerId = 205674020,
                Extended = true,
                Count = 3
            });
            foreach (VkNet.Model.Attachments.Post Post in Wall.WallPosts)
            {
                textBox1.Text += $"Пост от {Post.Date}, Просмотров: {Post.Views.Count}, \r\n \r\n";
                textBox1.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(Post.Text)) + "\r\n";
            }
        }
    }
}
