//Write a program that prints all the numbers from 1 to N.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print1ToN
{
    class Print1ToN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ",i);                
            }
            Console.WriteLine();
        }
    }
}
