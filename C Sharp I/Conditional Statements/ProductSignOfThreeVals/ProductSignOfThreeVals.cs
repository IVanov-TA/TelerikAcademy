//(task 2)Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSignOfThreeVals
{
    class ProductSignOfThreeVals
    {
        static void Main(string[] args)
        {
            int firstVal = int.Parse(Console.ReadLine());
            int secondVal = int.Parse(Console.ReadLine());
            int thirdVal = int.Parse(Console.ReadLine());
            bool sign = true;
            if (firstVal < 0)
            {
                sign = !sign;
            }
            if (secondVal < 0)
            {
                sign = !sign;
            }
            if (thirdVal < 0)
            {
                sign = !sign;
            }

            Console.WriteLine("Product of the three values is with sign \'{0}\'", sign ? '+' : '-');
        }
    }
}
