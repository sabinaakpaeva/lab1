using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroid_game
{
    public partial class Form1 : Form
    {
        private int x, y;
        public Form1()
        {
            InitializeComponent();
            x = 50;
            y = 50;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush (Color.Red), x, y, 100, 100);
        }

        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int d = r.Next(0,9);
            x += d;
            y += d;
            Invalidate();
        }
    }
}
