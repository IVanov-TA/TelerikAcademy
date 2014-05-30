//(task 7)Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPrime
{
    class CheckForPrime
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sqrt = (int)Math.Sqrt(input);
            if (input > 1) //check if the input is bigger than one because prime num is num > 1
            {
                if (input % 2 == 0)
                {
                    if (input == 2)
                    {
                        Console.WriteLine("Number is prime.");
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Number is not prime");
                    Environment.Exit(0);
                }
                for (int i = 3; i <= sqrt; i += 2)
                {
                    if ((input % i) == 0)
                    {
                        Console.WriteLine("Number is not prime");
                        Environment.Exit(0);
                        break;
                    }
                }
                Console.WriteLine("Number is prime.");
            }
            else
            {
                Console.WriteLine("Number is not prime.");
            }
        }
    }
}