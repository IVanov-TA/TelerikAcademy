using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Tribonacci
    {
        static void Main(string[] args)
        {
            checked
            {
                BigInteger T1 = BigInteger.Parse(Console.ReadLine());
                BigInteger T2 = BigInteger.Parse(Console.ReadLine());
                BigInteger T3 = BigInteger.Parse(Console.ReadLine());


                int N = int.Parse(Console.ReadLine());
                if (N > 3)
                {
                    BigInteger result = 0;

                    for (int i = 3; i < N; i++)
                    {
                        result = T1 + T2 + T3;
                        T1 = T2;
                        T2 = T3;
                        T3 = result;
                    }
                    Console.WriteLine(result);
                }
                else if (N == 1)
                {
                    Console.WriteLine(T1);
                }
                else if (N == 2)
                {
                    Console.WriteLine(T2);
                }
                else if (N == 3)
                {
                    Console.WriteLine(T3);
                }
               
            }
        }
    }
}
