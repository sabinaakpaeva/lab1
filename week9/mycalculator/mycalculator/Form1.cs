using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mycalculator
{
    public partial class Form1 : Form
    {
        public static Calculator calc;
 //       double memory;
  //      string symbol;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           // textBox1.Text += btn.Text;

             if (btn.Text == "+")
            {
                calc.oper = Calculator.Operation.PLUS;
            }
            
             if (btn.Text == "=")
            {
                calc.oper = Calculator.Operation.EQUAL;
            }
             
            if (btn.Text == "")
            {
                calc.oper = Calculator.Operation.NONE;
            }

            if (btn.Text == "1" || btn.Text == "2" || btn.Text == "3" || btn.Text == "4" || btn.Text == "5" || btn.Text == "6" || btn.Text == "7" || btn.Text == "8" || btn.Text == "9" || btn.Text == "0")
            {
                calc.oper = Calculator.Operation.NUMBER;
            }
            if (calc.oper == Calculator.Operation.NONE 
             || calc.oper == Calculator.Operation.NUMBER)
            {
                textBox1.Text += btn.Text;
            }

            if (calc.oper == Calculator.Operation.PLUS)
            {
                calc.saveFirstNumber(textBox1.Text);
                textBox1.Clear();
                textBox1.Text += btn.Text;
                calc.secondnumber = double.Parse(textBox1.Text);
                calc.result = calc.firstnumber + calc.secondnumber;
            }
            calc.oper = Calculator.Operation.NUMBER;

            if (calc.oper == Calculator.Operation.MINUS)
            {
                calc.saveFirstNumber(textBox1.Text);
                textBox1.Clear();
                textBox1.Text += btn.Text;
                calc.secondnumber = double.Parse(textBox1.Text);
            }
            calc.oper = Calculator.Operation.NUMBER;

            if (calc.oper == Calculator.Operation.EQUAL)
            {
                
                calc.saveSecondNumber(textBox1.Text);
                textBox1.Text = calc.result.ToString();

            }
                
        /*}
        
        /*private void operationbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Text == "=")
            {

                calc.secondnumber = double.Parse(textBox1.Text);

                if (symbol == "+")
                {
                    calc.firstnumber = calc.firstnumber + calc.secondnumber;
                    textBox1.Text = calc.firstnumber.ToString();
                }
                if (symbol == "-")
                {
                    calc.firstnumber = calc.firstnumber - calc.secondnumber;
                    textBox1.Text = calc.firstnumber.ToString();
                }
                if (symbol == "*")
                {
                    calc.firstnumber = calc.firstnumber * calc.secondnumber;
                    textBox1.Text = calc.firstnumber.ToString();
                }
                if (symbol == "/")
                {
                    calc.firstnumber = calc.firstnumber / calc.secondnumber;
                    textBox1.Text = calc.firstnumber.ToString();
                }
            }
            else if (btn.Text == "%")
            {
                calc.secondnumber = double.Parse(textBox1.Text);
                calc.secondnumber = calc.firstnumber * calc.secondnumber / 100;
                textBox1.Text = calc.secondnumber.ToString();

            }
            else if (btn.Text == "MS")
            {
                memory = double.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            else if (btn.Text == "MC")
            {
                memory = 0;
                textBox1.Text = "";
            }
            else if (btn.Text == "M+")
            {
                calc.firstnumber = double.Parse(textBox1.Text);
                textBox1.Text = (calc.firstnumber + memory).ToString();
            }
            else if (btn.Text == "M-")
            {
                calc.firstnumber = double.Parse(textBox1.Text);
                textBox1.Text = (calc.firstnumber - memory).ToString();
            }
            else if (btn.Text == "MR")
            {
                calc.firstnumber = double.Parse(textBox1.Text);
                textBox1.Text = (calc.firstnumber - memory).ToString();
            }
            else
            {
                calc.firstnumber = double.Parse(textBox1.Text);
                symbol = btn.Text;
                textBox1.Text = "";
            }
        }


        private void comma(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
            {
                if (textBox1.Text == "")
                    textBox1.Text = "0,";
                else
                    textBox1.Text = textBox1.Text + ",";
            }
            if (textBox1.Text.Contains(","))
            return;
        }

        private void inverse_divide(object sender, EventArgs e)
        {
            calc.saveFirstNumber(textBox1.Text);
            textBox1.Text = Convert.ToString(1 / calc.firstnumber);
        }

        private void percent(object sender, EventArgs e)
        {
            calc.saveFirstNumber(textBox1.Text);
            calc.saveSecondNumber(textBox1.Text);
            textBox1.Text = Convert.ToString(calc.firstnumber * calc.firstnumber/100);
        }

        private void nazad(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "0")
             
             if(textBox1.Text.Length == 1)
              {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);                 
                textBox1.Text = "0";
              }
              else
              {
                 return;
              }
                 textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void root(object sender, EventArgs e)
        {
            calc.saveFirstNumber(textBox1.Text);
            textBox1.Text = (Math.Sqrt(calc.firstnumber)).ToString();
        }

        private void sign(object sender, EventArgs e)
        {
            calc.saveFirstNumber(textBox1.Text);
            textBox1.Text = Convert.ToString(calc.firstnumber*(-1));
        }

        private void C(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void CE(object sender, EventArgs e)
        {
            calc.firstnumber = 0;
            textBox1.Text = "";
        }            
         * */
        }
    }
}
