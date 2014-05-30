//ZERG Task 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg
{
    class Zerg
    {
        static void Main()
        {
            string zergInput = Console.ReadLine();
            int power = 0;
            double result = 0;

            for (int i = zergInput.Length; i > 0; i -= 4, power++)
            {
                result += GetDecimalRepresentation(zergInput.Substring(i - 4, 4)) * Math.Pow(15, power);
            }
            Console.WriteLine("{0:0}", result);
        }

        private static long ConvertFrom15to10(int currentZrgDigit, int power)
        {
            long result = 0;

            return 0;
        }

        private static int GetPower(string zergInput)
        {
            int power = (zergInput.Length / 4) - 1;
            return power;
        }


        static int GetDecimalRepresentation(string zergDigit)
        {
            string[] zergDigits = new string[] { "Rawr", "Rrrr", "Hsst", "Ssst", 
                "Grrr", "Rarr", "Mrrr", "Psst", "Uaah", "Uaha", "Zzzz", "Bauu", 
                "Djav", "Myau", "Gruh" };

            return Array.IndexOf(zergDigits, zergDigit);
        }
    }
}
