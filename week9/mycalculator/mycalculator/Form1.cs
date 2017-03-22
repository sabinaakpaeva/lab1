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
        public string operations = "";
         public double firstnumber, secondnumber, result;
        public static Calculator calc;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {}

        private void number_click (object sender, EventArgs e)
        {
            Button btn = sender as Button;
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
                secondnumber = double.Parse(textBox1.Text);
            }
            calc.oper = Calculator.Operation.NUMBER;

            if (calc.oper == Calculator.Operation.MINUS)
            {
                calc.saveFirstNumber(textBox1.Text);
                textBox1.Text += btn.Text;
            }
            calc.oper = Calculator.Operation.NUMBER;

            /*if (calc.oper == Calculator.Operation.EQUAL)
            {
                calc.saveSecondNumber(textBox1.Text);

            }*/
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

        private void plus(object sender, EventArgs e)
        {
            calc.oper = Calculator.Operation.PLUS;
            operations = "+";

        }

        private void minus(object sender, EventArgs e)
        {

        }

        private void multiply(object sender, EventArgs e)
        {

        }

        private void divide(object sender, EventArgs e)
        {

        }

        private void equal(object sender, EventArgs e)
        {
            switch (operations)
            {
                case "+":
                    firstnumber = firstnumber + secondnumber;
                    textBox1.Text = firstnumber.ToString();
                    break;
                case "-":
                    firstnumber = firstnumber - secondnumber;
                    textBox1.Text = firstnumber.ToString();
                    break;
                case "x":
                     firstnumber = firstnumber * secondnumber;
                    textBox1.Text = firstnumber.ToString();
                    break;
                case "/":
                     firstnumber = firstnumber / secondnumber;
                    textBox1.Text = firstnumber.ToString();
                    break;
                case "%":
                    firstnumber = (firstnumber) / secondnumber * 100;
                    textBox1.Text = firstnumber.ToString();
                    break;
            }
        }

        private void inverse_divide(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(1 / firstnumber);
        }

        private void percent(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(firstnumber*firstnumber);
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
            textBox1.Text = (Math.Sqrt(firstnumber)).ToString();
        }

        private void sign(object sender, EventArgs e)
        {
            firstnumber = firstnumber * (-1);
            textBox1.Text = Convert.ToString(firstnumber);
        }

        private void C(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            firstnumber = 0;
        }

        private void CE(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }            
        }
    }
