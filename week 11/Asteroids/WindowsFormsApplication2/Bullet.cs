using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    class Bullet
    {
        int x, y, h, w;
        SolidBrush brush4 = new SolidBrush(Color.Green);

        public Bullet (int x, int y, int h, int w, SolidBrush brush4)
        {
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
            this.brush4 = brush4;
        }

        public void DrawBullet(Graphics g)
        {
            Point point1 = new Point(x - w, y);
            Point point2 = new Point(x, y - h);
            Point point3 = new Point(x + w, y);
            Point point4 = new Point(x, y + h);
            Point[] points = { point1, point2, point3, point4 };
            g.FillPolygon(brush4, points);

            Point point5 = new Point(x - h, y);
            Point point6 = new Point(x, y - w);
            Point point7 = new Point(x + h, y);
            Point point8 = new Point(x, y + w);
            Point[] points1 = { point5, point6, point7, point8 };
            g.FillPolygon(brush4, points1);
        }
    }
}
