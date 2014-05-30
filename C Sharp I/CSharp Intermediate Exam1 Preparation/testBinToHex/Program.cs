using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testBinToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int octaNum = 37;
            int power = 0;
            int decimalNum = 0;
            while (octaNum != 0)
            {
                int digit = octaNum % 2;
                decimalNum += digit * (int)Math.Pow(10, power);
                power++;
                octaNum /= 2;
            }
            Console.WriteLine(decimalNum);
            decimalNum++;
            power = 0;
            while (decimalNum != 0)
            {
                int digit = decimalNum % 10;
                octaNum += digit * (int)Math.Pow(2, power);
                power++;
                decimalNum /= 10;
            }
            Console.WriteLine(octaNum);
        }
    }
}
