﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font.FontFamily,trackBar1.Value);
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Value = (int)label2.Font.Size;
        }
    }
}
