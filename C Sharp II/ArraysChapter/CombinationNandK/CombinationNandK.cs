/*(task 21)Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationNandK
{
    class CombinationNandK
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
                   
                    int conv = i;
                    int[] array = new int[K];
                    bool toPrint = true;

                    for (int j = 0; j < K; j++)
                    {
                        array[K - j - 1] = conv % N;
                        conv /= N;
                    }
                    for (int j = 1; j < array.Length; j++)
                    {
                        if (array[j] <= array[j-1])
                        {
                            toPrint = false;
                        }
                    }
                    if (toPrint)
                    {
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
}
