using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text== "" || textBox2.Text.Length<=8)
            {
                MessageBox.Show("error : check that fields are not empty and password is not less than 8");
            }
            
            else if ( textBox1.Text == "admin")  
             {
                 if (textBox2.Text == "password123!" )
                 {
                    MessageBox.Show("success authorization!");
                 }
                 else
                     MessageBox.Show("error");
             }

            else
            {
                MessageBox.Show("error");
            }
       }
        }
    }

