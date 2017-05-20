using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_calc
{
    public partial class Form1 : Form
    {
        public static Calc calculator = new Calc();
        string symbol;
        public Form1()
        {
            InitializeComponent();
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox1.Text += btn.Text;

        }

        private void operation_cick(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            {
               
                if (btn.Text == "+")
                {
                    symbol ="+";
                    calculator.firstnumber = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                else if (btn.Text == "-")
                {
                    symbol = "-";
                    calculator.firstnumber = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                else if (btn.Text == "*")
                {
                    symbol = "*";
                    calculator.firstnumber = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }
                else if (btn.Text == "/")
                {
                    symbol = "/";
                    calculator.firstnumber = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                }

            }
                       
        }

        private void equal(object sender, EventArgs e)
        {
            calculator.secondnumber = double.Parse(textBox1.Text);
            if (symbol == "+")
            {
                textBox1.Text = calculator.Sum().ToString();
            }
            else if (symbol == "-")
            {
                textBox1.Text = calculator.Minus().ToString();
            }
            else if (symbol == "*")
            {
                textBox1.Text = calculator.Multiply().ToString();
            }
            else if (symbol == "/")
            {
                textBox1.Text = calculator.Divide().ToString();
            }
        }

    }
}
