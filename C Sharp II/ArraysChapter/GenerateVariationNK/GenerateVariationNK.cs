/*(task 20) Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateVariationNK
{
    class GenerateVariationNK
    {
        static void Main(string[] args)
        {
            int N;
            int K;

            while (!int.TryParse(Console.ReadLine(), out N))
            {
                Console.WriteLine("Please Enter N:");
            }
            while (!int.TryParse(Console.ReadLine(), out K))
            {
                Console.WriteLine("Please Enter K:");
            }

            if (K < 1)
            {
                Console.WriteLine("No variation available !!!");
            }
            else
            {
                for (int i = 0; i < Math.Pow(N, K); i++)
                {
                    Console.WriteLine(Math.Pow(N, K));
                    int conv = i;
                    int[] array = new int[K];

                    for (int j = 0; j < K; j++)
                    {
                        array[K - j - 1] = conv % N;
                        conv /= N;
                    }
                    Console.Write("{0}{1}", '{', array[0] + 1);
                    for (uint j = 1; j < K; j++)
                    {
                        Console.Write(", {0}", array[j] + 1);
                    }
                    Console.WriteLine("}");

                }
            }
        }
    }
}
