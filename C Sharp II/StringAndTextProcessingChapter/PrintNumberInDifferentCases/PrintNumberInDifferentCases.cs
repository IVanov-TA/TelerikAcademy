//(task 11)Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberInDifferentCases
{
    class PrintNumberInDifferentCases
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("decimal: {0,15:D}", number);
            Console.WriteLine("hex: {0,15:X}", number);
            Console.WriteLine("percent {0,15:P0}", number);
            Console.WriteLine("scientific  {0,15:E}", number);
        }
    }
}
