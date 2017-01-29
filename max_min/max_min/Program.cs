using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   // for working with files

namespace max_and_min
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HOME\lab1\max_min\text.txt"); // creats stream for reading 
            string s = sr.ReadLine(); // "9 64 25"
            string[] arr = s.Split(); // arr[0] = "9", arr[1] = "64", arr[3]="25"
            int a = int.Parse(arr[0]); // a = 9
            int b = int.Parse(arr[1]); // b = 64
            int c = int.Parse(arr[2]); // c = 25
            int[] numbers = { a, b, c }; // creat array for integers

            int max = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max) //checks every number in array for maximum
                {
                    max = numbers[i];
                }
            }

            int min = 1000000;
            for (int j = 0; j < numbers.Length; j++) //checks every number in array for minimum
            {
                if (numbers[j] < min)
                {
                    min = numbers[j];
                }
            }

            Console.WriteLine("maximum number is " + max); //shows maximum number on console
            Console.WriteLine("minimum number is " + min); //shows minimum number on console
            Console.ReadKey();
            sr.Close();
        }
    }
}
