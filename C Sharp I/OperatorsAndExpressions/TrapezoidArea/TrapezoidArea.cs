//(task 8)Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            double formula = ((a + b) / 2) * height;
            Console.WriteLine(formula);
        }
    }
}   
