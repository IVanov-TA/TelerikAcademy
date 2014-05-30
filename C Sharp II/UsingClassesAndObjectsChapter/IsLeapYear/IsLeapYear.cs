//(task 1) Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsLeapYear
{
    class IsLeapYear
    {
        static void Main()
        {
            int userYear = int.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.IsLeapYear(userYear));
        }
    }
}
