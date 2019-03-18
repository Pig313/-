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
        double temp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            temp = 0;
        }
        private void number_Click(object sender, EventArgs e)
        {
            Button number_Click = (Button)sender;
            textBox1.Text += number_Click.Text;

        }

        private void buttone_Click(object sender, EventArgs e)
        {
            string statement = textBox1.Text;
            char[] div = new char[] { '+', '-', '*', '/' };
            string[] numbers = statement.Split(div);
            int NumL = numbers.Length;
            char[] ops = new char[NumL - 1];
            int j = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                j += numbers[i].Length;
                ops[i] = statement[j + i];
            }
            temp = Convert.ToDouble(numbers[0]);
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == '+')
                {
                    temp = temp + Convert.ToDouble(numbers[i + 1]);
                }
                else if (ops[i] == '-')
                {
                    temp = temp - Convert.ToDouble(numbers[i + 1]);
                }
                else if (ops[i] == '*')
                {
                    temp = temp * Convert.ToDouble(numbers[i + 1]);
                }
                else if (ops[i] == '/')
                {
                    temp = temp / Convert.ToDouble(numbers[i + 1]);
                }
            }
            label1.Text = temp.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
