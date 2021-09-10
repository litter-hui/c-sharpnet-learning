using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)    //按键事件
        {
            string strResult;
            strResult = textBox1.Text + ",你好！欢迎使用本程序！";
            labelshow.Text = strResult;
        }

    }
}
