using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public static Calculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (calculator.operation == Calculator.Operation.NONE ||
       calculator.operation == Calculator.Operation.NUMBER)
            {
                textBox1.Text += btn.Text;
            }
            else if (calculator.operation == Calculator.Operation.PLUS)
            {
                calculator.saveFirstNumber(textBox1.Text);
                textBox1.Text = btn.Text;
            }
            calculator.operation = Calculator.Operation.NUMBER;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            calculator.operation = Calculator.Operation.PLUS;
        }


    }
}