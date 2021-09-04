using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace text2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelShow_Click(object sender, EventArgs e)
        {
            int a = 15, b, c, sum;
            b = c = 10;
            sum = a + b + c;
            labelShow.Text = "variable_sum=" + sum;
        }
    }
}
