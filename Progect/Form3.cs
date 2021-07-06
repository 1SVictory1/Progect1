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
        public Form3()
        {
            InitializeComponent();
        }
        Form2 fr2 = new Form2();
        private void Form3_Load(object sender, EventArgs e)
        {            

        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            fr2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var API_user = new VkApi();
            API_user.Authorize(new ApiAuthParams
            { AccessToken = Autoriz.getAuthForUser() });
            var Wall = API_user.Wall.Get(new WallGetParams
            {
                OwnerId = 213458891,
                Extended = true,
                Count = 2
            });
            foreach (VkNet.Model.Attachments.Post Post in Wall.WallPosts)
            {
                textBox1.Text += $"Пост от {Post.Date}, Просмотров: {Post.Views.Count}, \r\n \r\n";
                textBox1.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(Post.Text)) + "\r\n";
            }
        }
    }
}
