using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToInt32(sheshidu.Text);
            double f = 9.0 / 5 * c + 32;
            huashidu.Text = f.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "胡明辉";
        }


    }
}
