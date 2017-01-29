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
            int count = 0;  // counts number of divided numbers
            
            for (int i = 0; i < args.Length; i++) // cycle for entered numbers
            {
                count = 0;
                for (int j = 1; j <= int.Parse(args[i]); j++) // 1 2 3 4 5 ... divides till number in args
                {
                    if (int.Parse(args[i]) % j == 0) // checks whether the number is odd or even
                    {
                        count++;
                    }
                }

                if(count == 2) // checks whether the number is prime or not
                {
                    Console.WriteLine(args[i]);
                }
                count = 0;
            }
            Console.ReadKey();
        }
    }
}
