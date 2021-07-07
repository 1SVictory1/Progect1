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
        string pol;
        string group;
        private void button1_Click(object sender, EventArgs e)
        {
            pol = textBox1.Text;
            group = textBox2.Text;
            Form fr2 = new Form2(pol, group);
            this.Hide();
            fr2.Show();
        }
        private void sogl_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && sogl.Checked == true)
            {
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }
    }
}

