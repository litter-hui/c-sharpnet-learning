using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace text2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num1 = 5, num2 = 2;
            int a = num1 % num2;
            int b = num1 / num2;
            labelshow.Text = num1 + "%" + num2 + "=" + a;
            labelshow.Text += "\n" + num1 + "/" + num2 + "=" + b;
            a = num1++;
            b = --num2;
            labelshow.Text += "\n" + "a=num1++;后num1=" + num1 + ",a=" + a;
            labelshow.Text += "\n" + "b=--num2;后num2=" + num2 + ",b=" + b;
        }
    }
}
