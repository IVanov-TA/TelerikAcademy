using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TribonnachiTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                BigInteger firstDigit = BigInteger.Parse(Console.ReadLine());
                BigInteger secondDigit = BigInteger.Parse(Console.ReadLine());
                BigInteger thirdDigit = BigInteger.Parse(Console.ReadLine());
                int lines = int.Parse(Console.ReadLine());

                Console.WriteLine(firstDigit);
                Console.WriteLine("{0} {1}", secondDigit, thirdDigit);
                for (int i = 2; i < lines; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        BigInteger tmpNumber = firstDigit + secondDigit + thirdDigit;
                        BigInteger printNum = tmpNumber;
                        firstDigit = secondDigit;
                        secondDigit = thirdDigit;
                        thirdDigit = tmpNumber;

                        tmpNumber = 0;
                        if (j == i)
                        {
                            Console.Write(printNum);
                            tmpNumber = 0;
                            break;
                        }
                        Console.Write(printNum + " ");

                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
