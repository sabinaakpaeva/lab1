using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   // for working with files

namespace minimal_prime_number
{
    class Program
        {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\HOME\lab1\minimal_prime_number\input.txt"); // creats stream for reading 
            string s = sr.ReadLine(); // "9 64 25"
            string[] arr = s.Split(); // arr[0] = "9", arr[1] = "64", arr[3]="25"
            int a = int.Parse(arr[0]); // a = 9
            int b = int.Parse(arr[1]); // b = 64
            int c = int.Parse(arr[2]); // c = 25
            int[] numbers = { a, b, c }; // creat array for integers

            int count = 0;  // counts number of divided numbers
            for (int i = 0; i < numbers.Length; i++) // cycle for entered numbers
            {
                count = 0;
                for (int j = 1; j <= numbers.Length; j++) // 1 2 3 4 5 ... divides till number in args
                {
                    if (numbers[i] % j == 0) // checks whether the number is dividable 
                    {
                        count++;
                    }
                }

                if (count == 2) // checks whether the number is prime or not
                {   

                }
                count = 0;
            }

            int min = 1000000;
            for (int j = 0; j < numbers.Length; j++) //checks every number in array for minimum
            {
                if (numbers[j] < min)
                {
                    min = numbers[j];
                }
            }

            Console.WriteLine("minimum number is " + min); //shows minimum number on console
            Console.ReadKey();
            sr.Close();
        }
    }
}
