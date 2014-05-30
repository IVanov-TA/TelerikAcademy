//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitPositionForValueOne
{
    class CheckBitPositionForValueOne
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int numberV = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position you want to check: ");
            int positionP = int.Parse(Console.ReadLine());
            int mask = 1 << positionP;
            int checkVal = numberV & mask;
            int result = checkVal >> positionP;
            Console.WriteLine("\nValue for position ({0}) is 1: {1}", positionP, result == 1 ? true : false);
        }
    }
}
