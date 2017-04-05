using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    public class Spaceship
    {
        int x, y, height, width;
        SolidBrush brush2 = new SolidBrush(Color.Yellow);

         public Spaceship(int x, int y, int width, int height, SolidBrush brush2)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.brush2 = brush2;
        }

        public void DrawShip(Graphics g)
        {
            Point[] points = { new Point(x + width / 2, y), new Point(x + width, y + height / 4), new Point(x + width, y + height / 4 * 3),
            new Point(x + width / 2, y + height), new Point(x, y + height / 4 * 3), new Point(x, y + height / 4) };
            g.FillPolygon(brush2, points);
        }
    }
}
