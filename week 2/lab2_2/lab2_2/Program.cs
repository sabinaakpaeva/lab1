using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HOME\lab1\week 2\max_min\text1.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\HOME\lab1\week 2\max_min\text2.txt");
            string s = sr.ReadLine();
            string[] arr = s.Split();
            int[] numbers = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]);
            }

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            sw.WriteLine("max is " + max);
            sw.WriteLine("min is " + min);
            sw.WriteLine("sum is " + (max + min));
            sr.Close();
            sw.Close();
        }

    }
}
