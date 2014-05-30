//(task 1)Write an expression that checks if given integer is odd or even.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class EvenOrOdd
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Number {0} is {1}", input, input % 2 == 0 ? "even" : "odd");
        }
    }
}
