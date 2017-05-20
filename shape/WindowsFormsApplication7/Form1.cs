using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        MyShape shape1, shape2, shape3;
        public Form1()
        {
            InitializeComponent();
            shape1 = new MyShape(10, 10);
            shape2 = new MyShape(300, 100);
            shape3 = new MyShape(140, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(Color.Black), shape1.path);
            e.Graphics.DrawPath(new Pen(Color.Black), shape2.path);
            e.Graphics.DrawPath(new Pen(Color.Black), shape3.path);
        }

    }
}
