using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    public class Gun
    {
        int x, y, w, h;
        SolidBrush brush3 = new SolidBrush(Color.Green);

        public Gun (int x, int y, int h, int w, SolidBrush brush3)
        {
            this.x = x;
            this.y = y;
            this.h = h;
            this.w = w;
            this.brush3 = brush3;
        }

        public void DrawGun (Graphics g)
        {
            g.FillRectangle(brush3, x- 5, y, w, h);

            Point point1 = new Point(x - 10, y);
            Point point2 = new Point(x, y - 20);
            Point point3 = new Point(x + 10, y);
            Point[] points = { point1, point2, point3 };
            g.FillPolygon(brush3, points);
        }
    }
}
