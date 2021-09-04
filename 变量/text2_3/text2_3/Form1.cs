using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace text2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        struct Student
        {
            public int id;
            public string name;
            public int age;
            public char sex;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Student a;
            a.id = 0001;
            a.name = "小辉";
            a.age = 20;
            a.sex = '男';
            labelshow.Text = "student information\nname:" + a.name;
            labelshow.Text += "\nID:" + a.id;
            labelshow.Text += "\nSex:" + a.sex;
            labelshow.Text += "\nage:" + a.age;

        }
    }
}
