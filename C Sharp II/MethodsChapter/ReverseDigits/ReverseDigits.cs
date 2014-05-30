//Write a method that reverses the digits of given decimal number. Example: 256  652


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigits
{
    class ReverseDigits
    {
        static decimal ReverseNumber(decimal number)
        {
            return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
        }
       
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number));
        }
    }
}
