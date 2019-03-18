using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int a1 = 0;
        int a2 = 0;
        int a3 = 0;
        int a4 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;
            label1.Text = "";
        }
        private void number_Click(object sender, EventArgs e)
        {
            Button number_Click = (Button)sender;
            textBox1.Text = number_Click.Text;
            a2 = Convert.ToInt32(textBox1.Text);
            if (a3 == 0)
            {
                a4 = a1 + a2;
                textBox1.Text = a4.ToString();
            }
            if (a3 == 1)
            {
                a4 = a1 - a2;
                textBox1.Text = a4.ToString();
            }
            if (a3 == 2)
            {
                a4 = a1 * a2;
                textBox1.Text = a4.ToString();
            }
            if (a3 == 3 & a2 != 0)
            {
                a4 = a1 / a2;
                textBox1.Text = a4.ToString();
            }
            if (a3 == 3 & a2 == 0)
            {
                textBox1.Text = "Error";
            }
        }
        private void count_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            Button count_Click = (Button)sender;
            a1 = Convert.ToInt32(textBox1.Text);
            label1.Text = count_Click.Text;
            if(count_Click.Text == "+")
            {
                a3 = 0;
            }
            if (count_Click.Text == "-")
            {
                a3 = 1;
            }
            if (count_Click.Text == "*")
            {
                a3 = 2;
            }
            if (count_Click.Text == "/")
            {
                a3 = 3;
            }
            textBox1.Text = "";
        }

        private void buttone_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "Error")
            {
                textBox1.Text = a4.ToString();
            }
        }
    }
}
