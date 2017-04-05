using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    public class Star
    {
        public int x, y, height, width;
        public SolidBrush brush = new SolidBrush(Color.White);

        public Star (int x, int y, int height, int width, SolidBrush brush)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            this.brush = brush;
        }

        public void DrawShape (Graphics g)
        {
            g.FillEllipse(brush, x, y, width, height);
        }
    }
}
