using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace task3
{
    public class car
    {
        public int x, y, w, h;
        public SolidBrush brush = new SolidBrush(Color.Red);
        public SolidBrush brush2 = new SolidBrush(Color.Black);
        public car(int x, int y, int w, int h)
        {
            this.x=x;
            this.y=y;
            this.w=w;
            this.h=h;
        }
        public void DarwCar(Graphics g)
        {
            
                Point[] points = { new Point(x + w / 4, y), new Point(x + 3 * w / 4, y), new Point(x + 3 * w / 4, y + h / 2), new Point(x + w, y + h / 2), new Point(x + w, y + h),
                                 new Point(x, y + h), new Point(x, y + h / 2), new Point(x + w / 4, y + h / 2) };
            
            g.FillPolygon(brush, points);
            g.FillEllipse(brush2, x + w /8, y + h*3/4, w/4, h/2 );
            g.FillEllipse(brush2, x + w *3/4, y + h * 3 / 4, w / 4, h / 2);
        }
    }
}
