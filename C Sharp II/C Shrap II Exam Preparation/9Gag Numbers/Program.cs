using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _9Gag_Numbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().Trim();
            var currentValue = new StringBuilder();

            List<BigInteger> values = new List<BigInteger>();

            for (int i = 0; i < input.Length; i++)
            {
                currentValue.Append(input[i]);
                int tmpInt = GetGagNumber(currentValue);

                if (tmpInt >= 0)
                {
                    values.Add(tmpInt);
                    currentValue.Clear();
                }
            }

            ConvertFromGagToDecimal(values);
        }

        private static void ConvertFromGagToDecimal(List<BigInteger> values)
        {
            BigInteger result = 0;
            int power = values.Count - 1;

            for (int i = 0; i < values.Count; i++, power--)
            {
                result += values[i] * Pow(9, power);
            }
            Console.WriteLine(result);

        }

        private static BigInteger Pow(int p, int power)
        {
            BigInteger res = 1;
            for (int i = 0; i < power; i++)
            {
                res *= p;
            }
            return res;
        }

        private static int GetGagNumber(StringBuilder symbols)
        {
            int number;
            switch (symbols.ToString())
            {
                case "-!": number = 0; break;
                case "**": number = 1; break;
                case "!!!": number = 2; break;
                case "&&": number = 3; break;
                case "&-": number = 4; break;
                case "!-": number = 5; break;
                case "*!!!": number = 6; break;
                case "&*!": number = 7; break;
                case "!!**!-": number = 8; break;
                default: return -1; break;
            }
            return number;
        }
    }
}
