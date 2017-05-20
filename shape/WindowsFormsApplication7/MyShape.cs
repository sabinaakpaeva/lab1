using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication7
{
    class MyShape
    {
        public GraphicsPath path = new GraphicsPath();
        public MyShape(int x, int y)
        {
            path.AddLine(x + 10, y + 10, x + 100, y + 100);
            path.AddLine(x + 100, y + 100, x + 50, y + 80);
            path.AddLine(x + 50, y + 80, x + 10, y + 10);
        }
    }
}
