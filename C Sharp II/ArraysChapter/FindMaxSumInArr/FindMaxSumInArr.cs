/*(task 8) Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxSumInArr
{
    class FindMaxSumInArr
    {
        static void Main(string[] args)
        {
            //input
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int maxSum = int.MinValue;
            int startPosition = 0;
            int endPosition = 0;
            int tmpSum = 0;

            //solution
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i + j < array.Length)
                    {
                        tmpSum += array[i + j];
                    }

                    if (tmpSum > maxSum)
                    {
                        maxSum = tmpSum;
                        startPosition = i;
                        endPosition = i + j;
                    }
                }
                tmpSum = 0;
            }

            //output
            for (int i = startPosition; i <= endPosition; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine(maxSum);
        }
    }
}
