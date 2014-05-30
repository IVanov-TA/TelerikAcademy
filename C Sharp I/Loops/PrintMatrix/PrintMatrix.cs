//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            byte n;
            if (byte.TryParse(Console.ReadLine(), out n) && n < 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0,2} ", i + j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
