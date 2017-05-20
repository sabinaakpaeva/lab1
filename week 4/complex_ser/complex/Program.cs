using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Complex
{
    [Serializable]
   public class Complex
    {
        public int x;
        public int y;

        public Complex ()
        { }

        public Complex (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
           Complex c3 = new Complex(0, 0);
           c3.x = c1.x * c2.y + c2.x * c1.y;
           c3.y = c1.y * c2.y;

            if (c3.x > c3.y)
            {
                for (int num= c3.y; num>0; num --)
                {
                    if (c3.x % num == 0 && c3.y % num == 0)
                    {
                        int nod = num;
                        c3.x = c3.x / nod;
                        c3.y = c3.y / nod;
                    }
                    break;
                }
            }

            else
            {
                for (int num = c3.x; num>0; num--)
                {
                    if (c3.x % num == 0 && c3.y % num ==0)
                    {
                        int nod = num;
                        c3.x = c3.x / nod;
                        c3.y = c3.y / nod;
                    }
                    break;
                }
            }
            return c3;
        }

    

    public override string ToString()
    {
     return x+ "/" + y;
    }
    }



    class Program 
    {
        static void Save(Complex complex)
        {
            FileStream fs = new FileStream("ser1.xml", FileMode.OpenOrCreate);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            xs.Serialize(fs, complex);
            fs.Close();
            Console.WriteLine("Объект сериализован");
        }

        static void des(Complex com)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fz = new FileStream("ser1.xml", FileMode.OpenOrCreate);
            {
                Complex newcomplex = (Complex)xs.Deserialize(fz);
                Console.WriteLine("Объект десериализован");
            }
        }

        static void Main(string[] args)
        {
           
            Complex c1 = new Complex(2, 5);
            Complex c2 = new Complex(3, 4);
            Complex c3 = c1 + c2;
            Console.WriteLine(c3);
            string g = Console.ReadLine();
            if (g == "s")
            Save(c3);
          
            else if (g == "des")
            {
                des(c3);
            }
            
            Console.ReadKey();
        }
    }
}

