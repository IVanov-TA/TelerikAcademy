//(task 2)Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxInteger
{
    class GetMaxInteger
    {
        static int GetMax(int value1, int value2)
        {
            return value1 > value2 ? value1 : value2;
        }

        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(num1, num2), num3));
        }
    }
}
