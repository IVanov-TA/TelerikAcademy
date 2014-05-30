//(Task 4) Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForThirdDigit
{
    class CheckForThirdDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool result = false;
            if (input.Count() > 2) //check if string array is bigger than 2
            {
                int number = int.Parse(input); //parse the string
                number /= 100;
                int thirdDigit = number % 10;
                if (thirdDigit == 7)
                {
                    result = true;
                    Console.WriteLine("Third digit is {0} -> {1}", thirdDigit, result);
                }
                else
                {
                    Console.WriteLine("Third digit is different from 7 it is {0} ->", thirdDigit, false);
                }
            }
            else
            {
                Console.WriteLine("There is no third digit :) -> {0}", result);
            }


        }
    }
}
