using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split();
            int[] numbers = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]); 
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 1; j <= numbers[i]; j++)
                {
                    if (numbers[i] % j == 0 && numbers[i+1] %j==0)
                    {
                        Console.WriteLine(j);
                    }
                }
            }
            Console.ReadKey();
        }
    }

}
