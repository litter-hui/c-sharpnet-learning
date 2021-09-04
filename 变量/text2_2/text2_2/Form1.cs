using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace text2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        enum Season { Spring = 10, Summer, Autumn = 20, Winter };

        private void Form1_Load(object sender, EventArgs e)
        {
            Season a, b;
            a = Season.Summer;
            b = (Season)21;
            labelshow.Text = "enum variate a = " + (int)a;
            labelshow.Text += "\nenum variate b is " + b;

        }


    }
}
