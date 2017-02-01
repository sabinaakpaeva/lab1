using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int a;
        public int b;

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(0, 0);
            c3.a = c1.a * c2.b - c2.a * c1.b;
            c3.b = c1.b * c2.b;
            return c3;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(2, 3);
            Complex c3 = c1 - c2;
            Console.WriteLine(c3.a + "/" + c3.b);
            Console.ReadKey();
        }
    }
}