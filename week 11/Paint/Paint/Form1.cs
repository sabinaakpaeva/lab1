using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        bool mouseClicked = false;
        Point prevpoint = new Point(0, 0);
        
     //   public int x1, x2, y1, y2, w, h;
        public Form1()
        {
            InitializeComponent();
           /* x1 = 10;
            x2 = 0;
            y1 = 10;
            y2 = 0;
            w = 20;
            h = 20;*/
           /* bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            g.DrawLine(new Pen(Color.Red), 10, 10, 100, 100);*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           // e.Graphics.DrawLine(new Pen(Color.Red), x1, x2, y1, y2);
            /*Pen pen = new Pen(Color.Red);
            SolidBrush brush = new SolidBrush(Color.Plum);
            e.Graphics.DrawLine(pen, 10, 10, 100, 100);
            e.Graphics.FillEllipse(brush, 10, 10, 100, 200);*/
           // e.Graphics.DrawEllipse(new Pen(Color.Red), x1, y1, w, h);

        }

     /*   private void button1_Click(object sender, EventArgs e)
        {
            x1 = int.Parse(textBox1.Text);
            x2 = int.Parse(textBox2.Text);
            y1 = int.Parse(textBox3.Text);
            y2 = int.Parse(textBox4.Text);
            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x1 += 10;
            Refresh();
        }*/

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            /*mouseX = e.Location.X;
            mouseY= e,Location.Y;*/
            prevpoint = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
        }

        private void pictureBox1_Move(object sender, MouseEventArgs e)
        {
            if (mouseClicked)
            {
                g.DrawLine(new Pen(Color.Blue), prevpoint.X, prevpoint  .Y,e.Location.X, e.Location.Y );
                pictureBox1.Refresh();
            }
        }

    }
}
