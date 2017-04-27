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

namespace task3
{
    public partial class Form1 : Form
    {
        
        public int x, y, w, h;
        public Form1()
        {
            InitializeComponent();
            x = 300;
            y = 100;
            w = 100;
            h = 50;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Red);
            car car1 = new car(x,y,w,h);
            car1.DarwCar(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 10;
            if (x>=457)
            {
                x = 0;
            }
            pictureBox1.Refresh();
        }

        

    }
}
