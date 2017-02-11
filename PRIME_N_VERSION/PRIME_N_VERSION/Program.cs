using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME_N_VERSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers");
            string s = Console.ReadLine(); // "7 8 5"
            string[] arr = s.Split(); // arr[0] = "7", arr[1] = "8", arr[3]="5"

            int[] numbers = new int[arr.Length];//new array to store numbers as integers

            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]); // converting into integer
            }

            for (int i = 0; i <numbers.Length; i++)
            {
               int count = 0;  // counts number of divided numbers
                {
                    count = 0;
                    for (int j = 1; j <= numbers[i]; j++) // 1 2 3 4 5 ... divides till number in args
                    {
                        if (numbers[i] % j == 0) 
                        {
                            count++;
                        }
                    }

                    if (count == 2) // checks whether the number is prime or not
                    {
                        Console.WriteLine(arr[i]);
                    }
                    count = 0;
                }
            }
            Console.ReadKey();
        }
    }
    
}
