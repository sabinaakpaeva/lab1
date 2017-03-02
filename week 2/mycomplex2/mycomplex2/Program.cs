using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mycomplex2
{
    class complex
    {
        public int x;
        public int y;
        public double l;
        public complex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    
        public static double operator + (complex c1, complex c2)
        {
            double l = (c1.x + c2.x) / (c1.y - c2.y);
            return l;
        }
        static void Main(string[] args)
        {
            complex c1 = new complex(5, 10);
            complex c2 = new complex(3, 6);
            double length = c1 + c2;
            Console.WriteLine(length);
            Console.ReadKey();
        }
    }
}
