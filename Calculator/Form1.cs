using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "*";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "9";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "0";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "+";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "-";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "/";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + "%";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string exp = txt1.Text;
            char ch;
            string ex1 = "";
            int j = 0;
            string ex2;
            int pos=0;
            for(int i=0; i < (exp.Length - 1); i++)
            {
                ch = exp.ElementAt(i);
                if (j == 0)
                {
                    if (ch != '+' && ch != '-' && ch != '/' && ch != '*' && ch != '%')
                    {
                        ex1 = ex1 + ch;
                    }
                    else
                    {
                        pos = i;
                        j=56;
                    }
                }
                else
                {
                }
            }
            ex2 = exp.Substring(pos+1);
            int num1 = Convert.ToInt32(ex1);
            int num2 = Convert.ToInt32(ex2);
            int result=0;
            switch (exp.ElementAt(pos))
            {
                case '+': result = num1 + num2; break;
                case '-': result = num1 - num2; break;
                case '*': result = num1 * num2; break;
                case '/': result = num1 / num2; break;
                case '%': result = num1 % num2; break;

            }
            txt1.Text =Convert.ToString(result);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
        }
    }
}
