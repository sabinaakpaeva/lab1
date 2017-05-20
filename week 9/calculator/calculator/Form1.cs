using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isoperationPerformed = false;
        bool cleartextbox = false;
        decimal memory = 0;
        public Form1()
        {

            InitializeComponent();
        }
        private void Equal(object sender, EventArgs e)
        {

            switch (operationPerformed)
            {
                case "+":
                    TextBox1.Text = (resultValue + double.Parse(TextBox1.Text)).ToString();
                    break;
                case "-":
                    TextBox1.Text = (resultValue - double.Parse(TextBox1.Text)).ToString();
                    break;
                case "*":
                    TextBox1.Text = (resultValue * double.Parse(TextBox1.Text)).ToString();
                    break;
                case "/":
                    TextBox1.Text = (resultValue / double.Parse(TextBox1.Text)).ToString();
                    break;
                case "%":
                    TextBox1.Text = (resultValue * double.Parse(TextBox1.Text) / 100).ToString();
                    break;

                default:
                    break;

            }

            cleartextbox = true;

            resultValue = 0; // double.Parse(textBox1.Text);
            TextBox1.Text = " ";
            //textBox1 .Text= "0";
        }

        private void button_click(object sender, EventArgs e)
        {
            if (cleartextbox)
            {
                TextBox1.Text = "";
                TextBox1.Clear();
                cleartextbox = false;
            }
            if ((TextBox1.Text == "0") || (isoperationPerformed))
                TextBox1.Clear();
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!TextBox1.Text.Contains(","))
                    TextBox1.Text = TextBox1.Text + button.Text;
            }
            else
                TextBox1.Text = TextBox1.Text + button.Text;
            isoperationPerformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                //textBox1.Clear();
                button34.PerformClick();
                operationPerformed = button.Text;
                TextBox1.Text = resultValue + " " + operationPerformed;
                resultValue = 0;
                isoperationPerformed = true;

            }
            else
            {

                operationPerformed = button.Text;
                resultValue = double.Parse(TextBox1.Text);

                TextBox1.Text = resultValue + " " + operationPerformed;

                isoperationPerformed = true;

            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            resultValue = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "0";
            resultValue = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length > 0)
            {
                TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1);
            }
            if (TextBox1.Text == "")
            {
                TextBox1.Text = "0";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(TextBox1.Text);
            TextBox1.Text = System.Convert.ToString("log" + "(" + TextBox1.Text + ")");
            sq = Math.Sqrt(sq);
            TextBox1.Text = System.Convert.ToString(sq);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(TextBox1.Text));
            TextBox1.Text = System.Convert.ToString(a);
        }

        /*private void button19_Click(object sender, EventArgs e)
        {
            double a,b,c;
            a = double.Parse(textBox1.Text);
           // Button button = button19.Text;
            textBox1.Clear();
            b = double.Parse(textBox1.Text);
            c = (a * b) / 100;
            textBox1.Text = c.ToString();
        }*/

        private void button23_Click(object sender, EventArgs e)
        {
            decimal currVal = decimal.Parse(TextBox1.Text);
            currVal = -currVal;
            TextBox1.Text = currVal.ToString();
        }
        private void button25_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            TextBox1.Text = memory.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            memory = decimal.Parse(TextBox1.Text);
            TextBox1.Clear();
        }

        /*   private void button28_Click(object sender, EventArgs e)
           {
               if (memory == 0)
               {
                   memory = decimal.Parse(textBox1.Text);
               }
               else {
                   memory = memory + decimal.Parse(textBox1.Text);
               }
           }

           private void button29_Click(object sender, EventArgs e)
           {
               if (memory == 0)
               {
                   memory = decimal.Parse(textBox1.Text);
               }
               else
               {
                   memory = memory + decimal.Parse(textBox1.Text);
               }
         * }

           */


    }
}
