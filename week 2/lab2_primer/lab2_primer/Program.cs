using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_primer
{
    class Program
    {
        static void emptyspace(int p)
        {
            for (int i=0; i<p; i++)
            {
                Console.Write("->");
            }
        }
        static void lab2 (string path, int level)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                Console.WriteLine("directories:" + directory.GetDirectories().Length);
                DirectoryInfo[] direc = directory.GetDirectories();
                foreach(DirectoryInfo dir in direc)
                {
                    emptyspace(level);
                    Console.WriteLine(dir.Name);
                    Console.WriteLine(dir.FullName);
                    lab2(dir.FullName, level + 1);
                }

                Console.WriteLine();

                Console.WriteLine("files:" + directory.GetFiles().Length);
                FileInfo[] files = directory.GetFiles();
                foreach (FileInfo file in files)
                {
                    emptyspace(level);
                    Console.WriteLine(file.Name);
                    Console.WriteLine(file.FullName);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("there is an error");
            }
           
        }


        static void Main(string[] args)
        {
            lab2(@"C:\Users\HOME\Desktop\programing technologies\ConsoleApplication1", 1);
            Console.ReadKey();
        }
    }
}
