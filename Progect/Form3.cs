﻿using System;
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
        string _pol;
        string _group;
        List<string> _users;
        String[] Users;
        List<string> _users_id;
        int Number_user;
        public Form3(string pol, string group, List<string> users, List<string> users_id)
        {
            InitializeComponent();
            _pol = pol;
            _group = group;
            _users = users;
            Users = _users.ToArray();
            comboBox1.Items.AddRange(Users);
            _users_id = users_id;
        }
        private void nazad_Click(object sender, EventArgs e)
        {
            Form fr3 = new Form2(_pol, _group);
            this.Hide();
            fr3.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Number_user = comboBox1.SelectedIndex;
            var API_user = new VkApi();
            API_user.Authorize(new ApiAuthParams
            { AccessToken = _pol });
            var Wall = API_user.Wall.Get(new WallGetParams
            {
                OwnerId = Convert.ToInt32(_users_id[Number_user]),
                Extended = true,
                Count = 10
            });
            foreach (VkNet.Model.Attachments.Post Post in Wall.WallPosts)
            {
                textBox1.Text += $"Пост от {Post.Date}, Просмотров: {Post.Views.Count}, \r\n \r\n";
                textBox1.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(Post.Text)) + "\r\n";
            }
        }
    }
}
