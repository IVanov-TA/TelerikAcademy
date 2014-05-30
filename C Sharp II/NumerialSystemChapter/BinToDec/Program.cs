//(task 2)Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinToDec
{
    class Program
    {
        static void Main()
        {

            int binaryNum = int.Parse(Console.ReadLine());
            CheckNumber(binaryNum);
        }

        static void CheckNumber(int number)
        {
            StringBuilder sb = new StringBuilder();
            bool ok = false;
            while (number != 0)
            {
                int digit = number % 10;
                if (digit <= 1)
                {
                    sb.Append(digit);
                }
                else
                {
                    ok = true;
                    break;
                }
                number /= 10;
            }
            if (!ok)
            {
                ConvertBinToDec(sb);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

        }

        static void ConvertBinToDec(StringBuilder sb)
        {
            int power = 0;
            int result = 0;

            for (int i = 0; i < sb.Length; i++, power++)
            {
                result += ((int)sb[i] - 48) * (int)Math.Pow(2, power);
            }
            PrintResult(result);
        }

        static void PrintResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
