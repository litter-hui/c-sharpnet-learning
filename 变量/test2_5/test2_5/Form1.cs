using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a, b = 5;
            char c = '中';
            a = c + 2;
            labelshow.Text = "variable int a =" + a;
            double x = 42;
            x /= b;
            labelshow.Text += "\nvariable double x=" + x;
        }

    }
}
