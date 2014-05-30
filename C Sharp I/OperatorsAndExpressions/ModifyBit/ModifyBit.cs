/*(task 12) We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
	n = 5 (00000101), p=2, v=0 -> 1 (00000001) */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int numberN = int.Parse(Console.ReadLine());   //Read from the console
            Console.Write("Enter position: ");
            int positionP = int.Parse(Console.ReadLine()); //Read from the console
            Console.Write("Enter value (0/1): ");
            byte valueV = byte.Parse(Console.ReadLine());  //Read from the console

            int mask = 1 << positionP; //Crete mask and move the bit to the positionP

            int newNum; //create value newNum
            string maskBinary;
            string maskBinaryIversed;

            if (valueV == 1)
            {
                newNum = numberN | mask;
            }
            else
            {
                newNum = numberN & ~(mask);
            }

            string binaryNumberN = Convert.ToString(numberN, 2).PadLeft(32, '0');
            string binaryNewNum = Convert.ToString(newNum, 2).PadLeft(32, '0');
            Console.WriteLine("\nRESULT:\n\n{0} : Number({1})\n{2} : Mask\n{3} : NewNumber({4})\n\n", binaryNumberN, numberN,
                  valueV == 1 ? maskBinary = Convert.ToString(mask, 2).PadLeft(32, '0') : maskBinaryIversed = Convert.ToString(~(mask), 2).PadLeft(32, '0'), binaryNewNum, newNum); //Print the result
        }
    }
}

