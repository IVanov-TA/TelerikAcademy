using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int binDigit = int.Parse(Console.ReadLine());
            int numNumbers = int.Parse(Console.ReadLine());
            uint[] values = new uint[numNumbers];

            for (int i = 0; i < numNumbers; i++)
            {
                values[i] = uint.Parse(Console.ReadLine());
            }


            for (int i = 0; i < numNumbers; i++)
            {
                string val = Convert.ToString(values[i], 2);
                int countbitPositions = val.Length;
                int tmpResult = 0;

                for (int j = 0; j < countbitPositions; j++)
                {
                    long mask;
                    mask = 1 << j;
                    mask &= values[i];
                    mask >>= j;
                    if (mask == binDigit)
                    {
                        tmpResult++;
                    }
                }
                Console.WriteLine("{0}", tmpResult);
            }

        }
    }
}
