using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace text7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = "  ";
            string[] sources = textBox1.Text.Split(',');
            int[] a = new int[sources.Length];
            for (int i = 0; i < sources.Length; i++)
            {
                a[i] = Convert.ToInt32(sources[i]);
            }
            for (int i = 1; i < a.Length; i++)
            {
                for(int j=1;j<a.Length-i;j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        int t = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = t;
                    }
                }

            }
            foreach (int t in a)
            {
                result.Text += string.Format("{0,-4:D}", t);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "胡明辉";

        }
    }
}
