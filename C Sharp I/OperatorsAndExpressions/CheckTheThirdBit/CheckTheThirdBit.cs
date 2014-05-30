//(task 5)Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTheThirdBit
{
    class CheckTheThirdBit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int checkBitFor = int.Parse(Console.ReadLine());
            bool result = false;
            int mask = checkBitFor << 3;
            int numberAndMask = number & mask;
            numberAndMask = numberAndMask >> 3;
            if (numberAndMask == checkBitFor)
            {
                result = true;
            }
            Console.WriteLine(result);
        }
    }
}
