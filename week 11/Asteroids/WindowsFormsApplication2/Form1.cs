using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public int x, y,x1, y1 ,x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, x7, y7, w, h, x_direction, y_direction;
        public Form1()
        {
            InitializeComponent();
             x = 70;
             y = 70;
             x1 = 70;
             y1 = 70;
             x2 = 70;
             y2 = 70;
             x3 = 70;
             y3 = 70;
             x4 = 70;
             y4 = 70;
             x5 = 70;
             y5 = 70;
             x6 = 70;
             y6 = 70;
             x7 = 70;
             y7 = 70;
             w = 30;
             h = 30;
            
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            Star star1 = new Star(x, y, h, w, brush);
            star1.DrawShape(e.Graphics);
            Star star2 = new Star(x1+230, y1-20, 30, 30, brush);
            star2.DrawShape(e.Graphics);
            Star star3 = new Star(x2+430, y2+20, 30, 30, brush);
            star3.DrawShape(e.Graphics);
            Star star4 = new Star(x3+630, y3+70, 30, 30, brush);
            star4.DrawShape(e.Graphics);
            Star star5 = new Star(x4+20, y4+310, 30, 30, brush);
            star5.DrawShape(e.Graphics);
            Star star6 = new Star(x5+230, y5+280, 30, 30, brush);
            star6.DrawShape(e.Graphics);
            Star star7 = new Star(x6+560, y6+180, 30, 30, brush);
            star7.DrawShape(e.Graphics);
            Star star8 = new Star(x7+630, y7+330, 30, 30, brush);
            star8.DrawShape(e.Graphics);

            SolidBrush brush1 = new SolidBrush(Color.Red);
            Asteroid as1 = new Asteroid(170, 130, brush1);
            as1.DrawAsteroid(e.Graphics);
            Asteroid as2 = new Asteroid(650, 115, brush1);
            as2.DrawAsteroid(e.Graphics);
            Asteroid as3 = new Asteroid(200, 300, brush1);
            as3.DrawAsteroid(e.Graphics);
            Asteroid as4 = new Asteroid(510, 360, brush1);
            as4.DrawAsteroid(e.Graphics);

            SolidBrush brush2 = new SolidBrush(Color.Yellow);
            Spaceship ship = new Spaceship(350, 200, 100, 100, brush2);
            ship.DrawShip(e.Graphics);

            SolidBrush brush3 = new SolidBrush(Color.Green);
            Gun gun = new Gun(400, 250, 25, 10, brush3);
            gun.DrawGun(e.Graphics);

            SolidBrush brush4 = new SolidBrush(Color.Green);
            Bullet bullet = new Bullet(420, 150, 20, 5, brush4);
            bullet.DrawBullet(e.Graphics);
           
        }

        Random rnd1 = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            x += 5;
            y += 5;
            if (x == 10)
            {
                x += -5;
            }
           
            if (y==pictureBox1.Height)
            {
                y = 0;
            }
            /* x_direction = rnd1.Next(0,1);
             y_direction = rnd1.Next(0,1);
            if (x_direction == 0)
            {
                x += 10;
            }
            else if (x_direction == 1)
            {
                x -= 10;
            }
            if (y_direction == 0)
            {
                y += 10;
            }
            else if (y_direction == 1)
            {
                y -= 10;
            }
             */
             pictureBox1.Refresh();
        }

    }
}
