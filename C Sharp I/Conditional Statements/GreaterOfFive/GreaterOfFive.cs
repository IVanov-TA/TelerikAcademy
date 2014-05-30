//(task 7)Write a program that finds the greatest of given 5 variables.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfFive
{
    class GreaterOfFive
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int greater = a;

            if (b > greater)
            {
                greater = b;
            }
            if (c > greater)
            {
                greater = c;
            }
            if (d > greater)
            {
                greater = d;
            }
            if (e > greater)
            {
                greater = e;
            }
            Console.WriteLine(greater);
        }
    }
}
