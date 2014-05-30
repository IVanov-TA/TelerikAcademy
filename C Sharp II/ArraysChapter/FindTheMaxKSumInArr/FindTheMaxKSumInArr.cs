//(task 6)Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheMaxKSumInArr
{
    class FindTheMaxKSumInArr
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            //initiliaze the array
            int[] arrayN = new int[N];

            //fill the array with value
            for (int i = 0; i < arrayN.Length; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }

            //solution
            int maxSum = 0;
            int tmpSum = 0;

            for (int i = 0; i <= arrayN.Length - K; i++)
            {
                tmpSum = 0;
                for (int j = i; j < K + i; j++)
                {
                    tmpSum += arrayN[j];
                }

                if (tmpSum > maxSum)
                {
                    maxSum = tmpSum;
                }
            }

            //output
            Console.WriteLine(maxSum);
        }
    }
}
