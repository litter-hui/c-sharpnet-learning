using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2
{
    public partial class win : Form
    {
        public win()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "这是我的第一个Win程序";    //左上角窗体的名字
            Label lblShow = new Label();
            lblShow.Location = new Point(50, 30);
            lblShow.AutoSize = true;
            lblShow.Text = "本程序由LITTER_HUI设计";
            this.Controls.Add(lblShow);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
