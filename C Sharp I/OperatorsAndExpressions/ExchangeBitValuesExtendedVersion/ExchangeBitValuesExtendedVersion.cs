//(task 14*) * Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeBitValuesExtendedVersion
{
    class ExchangeBitValuesExtendedVersion
    {
        static void Main(string[] args)
        {
            Console.Write("How many bits do you want to change: ");
            byte bitCount = byte.Parse(Console.ReadLine());

            Console.Write("First Group Bits to start from: ");
            byte startGroup = byte.Parse(Console.ReadLine());

            Console.Write("Second Group Bits to start from: ");
            byte endGroup = byte.Parse(Console.ReadLine());

            uint number = 117440809;
            string numBinary = Convert.ToString(number, 2).PadLeft(32, '0');
            Console.WriteLine(numBinary);

            uint mask1 = 1;

            for (int i = 1; i < bitCount; i++)
            {
                mask1 |= mask1 << 1;
            }

            Console.WriteLine(mask1);
            Console.WriteLine(Convert.ToString(mask1, 2).PadLeft(32, '0'));

            uint getFstBits = (number & (mask1 << startGroup)) << (endGroup - startGroup);
            uint getSndBits = (number & (mask1 << endGroup)) >> (endGroup - startGroup);

            uint changNum = (number & ~(mask1 << startGroup)) & ~(mask1 << endGroup);
            Console.WriteLine(Convert.ToString(changNum, 2).PadLeft(32, '0'));

            uint newNum = (changNum | getFstBits) | getSndBits;
            Console.WriteLine(Convert.ToString(newNum, 2).PadLeft(32, '0'));
        }
    }
}

