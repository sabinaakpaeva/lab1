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
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0;
        int y = 0;
        int w = 30;
        int h = 30;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            Star star1 = new Star(x+70,y+70, h, w, brush);
            star1.DrawShape(e.Graphics);
            Star star2 = new Star(300, 50, 30, 30, brush);
            star2.DrawShape(e.Graphics);
            Star star3 = new Star(500, 90, 30, 30, brush);
            star3.DrawShape(e.Graphics);
            Star star4 = new Star(700, 140, 30, 30, brush);
            star4.DrawShape(e.Graphics);
            Star star5 = new Star(90, 380, 30, 30, brush);
            star5.DrawShape(e.Graphics);
            Star star6 = new Star(300, 350, 30, 30, brush);
            star6.DrawShape(e.Graphics);
            Star star7 = new Star(630, 250, 30, 30, brush);
            star7.DrawShape(e.Graphics);
            Star star8 = new Star(700, 400, 30, 30, brush);
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

    }
}
