using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    public class Asteroid
    {
        public int x,y;
        public SolidBrush brush1 = new SolidBrush(Color.Red);
        public Asteroid (int x, int y, SolidBrush brush1)
        {
            this.x = x;
            this.y = y;
            this.brush1 = brush1;
        }

        public void DrawAsteroid(Graphics g)
        {
          Point point1 = new Point(x, y+20);
          Point point2 = new Point(x+30, y - 20);
          Point point3 = new Point(x-30, y - 20);
          Point[] points = {point1, point2, point3};
          g.FillPolygon(brush1, points);

          Point point4 = new Point(x-30, y + 10);
          Point point5 = new Point(x + 30, y +10);
          Point point6 = new Point(x, y - 30);
          Point[] points1 = { point4, point5, point6 };
          g.FillPolygon(brush1, points1);
        }
        

    }
}
