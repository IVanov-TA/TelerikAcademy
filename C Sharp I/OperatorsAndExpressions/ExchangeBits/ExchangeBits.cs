//(task 13) Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            int number = 117440809;
            string numBinary = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine(numBinary);

            int position1 = 3;
            int position2 = 24;

            int mask1 = 7 << position1; //use 7 because binary representation is 111
            int mask2 = 7 << position2; //use 7 because binary representation is 111

            int getNumbers1 = number & mask1;
            int getNumbers2 = number & mask2;
            int change = (number & ~mask1) & ~mask2;

            int mask3 = (getNumbers1 >> position1) << position2;
            int mask4 = (getNumbers2 >> position2) << position1;
            int result = (change | mask3) | mask4;
            string resultBinary = Convert.ToString(result, 2).PadLeft(32, '0');
            Console.WriteLine(resultBinary);
        }
    }
}
