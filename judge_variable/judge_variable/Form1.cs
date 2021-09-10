using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace judge_variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str2 = textBox.Text;
            string result=null;
            byte[] array = System.Text.Encoding.ASCII.GetBytes(str2);  //数组array为对应的ASCII数组 
            int asciicode = (int)(array[0]);
            if (asciicode >= 48 && asciicode <= 57)             //0----48   9---57  也可以用‘0’  ‘9’
                {
                   result="数字字符";
                }
            else if(asciicode >= 65 && asciicode <= 90)         //A----65    Z----90
                {
                    result="大写字符";
                }
            else if (asciicode >= 97 && asciicode <= 122)       //a----97   z----122
                {
                    result = "小写字符";
                }
            else                                                //
                {
                    result = "其他字符";
                }
            label2.Text = result;


            //string ASCIIstr2 = null;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    int asciicode = (int)(array[i]);
            //    ASCIIstr2 += Convert.ToString(asciicode);//字符串ASCIIstr2 为对应的ASCII字符串
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "First_Group";
            Label lblShow=new Label();
            lblShow.Location = new Point(350, 180);
            lblShow.AutoSize = true;
            lblShow.Text = "Design by 第一组";
            this.Controls.Add(lblShow);
        }

    }
}
