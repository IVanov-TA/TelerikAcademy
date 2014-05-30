//(task 11)Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitValueOnPosition
{
    class BitValueOnPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int numberV = int.Parse(Console.ReadLine());
            Console.Write("Enter bit position you want to check: ");
            int positionP = int.Parse(Console.ReadLine());
            int mask = 1 << positionP; //creating mask
            int checkVal = numberV & mask; //checking the value
            int result = checkVal >> positionP;
            Console.WriteLine("\nValue of the ({0})bit is: {1}", positionP, result == 1 ? 1 : 0); //return result
        }
    }
}
