//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSumNX
{
    class CalculateSumNX
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            double s = 1,fact = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    fact *= j;
                }
                s += fact / Math.Pow(x, i);
                fact = 1;
            }

            Console.WriteLine(s);
        }
    }
}
