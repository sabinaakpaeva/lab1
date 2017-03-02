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
            StreamReader sr = new StreamReader(@"C:\Users\HOME\lab1\week 2\minimal_prime_number\input.txt"); // creats stream for reading from file
            StreamWriter sw = new StreamWriter(@"C:\Users\HOME\lab1\week 2\minimal_prime_number\output.txt");//file for writing the answer
            string s = sr.ReadLine(); // "7 8 5"
            string[] arr = s.Split(); // arr[0] = "7", arr[1] = "8", arr[3]="5"

            int[] numbers = new int[arr.Length];//new array to store numbers as integers

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]); // converting into integer
            }

            int[] primes = new int[100];
            int min = primes[0]; // 


            for (int i = 0; i < numbers.Length; i++) // cycle for entered numbers
            {
                int count = 0; // counter in order to identify number of dividers
                for (int j = 1; j <= numbers[i]; j++) // 1 2 3 4 5 ... divides till number in args
                {
                    if (numbers[i] % j == 0) // checks whether the number is divideable 
                    {
                        count++;
                    }
                }

                
                if (count == 2) // checks whether the number is prime or not
                {
                    
                    for (int j; j < primes.Length; j++)
                    {
                        primes[j] = numbers[i];
                        if (numbers[i] < min)
                        min = numbers[i];  //sets minimum
                    }
                }
            }

            sw.WriteLine(min); // writes answer in file
            sr.Close();
            sw.Close();
        }
    }
}
