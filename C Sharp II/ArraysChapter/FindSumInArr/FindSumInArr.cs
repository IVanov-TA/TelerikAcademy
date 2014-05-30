/*(task 10) Write a program that finds in given array of integers a sequence of given sum S (if present). Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInArr
{
    class FindSumInArr
    {
        static void Main(string[] args)
        {
            //input
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int S = 11;

            int startLenght = 0;
            int endLendght = 0;

            //solution
            for (int i = 0; i < array.Length; i++)
            {
                int tmpSum = 0;

                for (int j = i; j < array.Length; j++)
                {

                    tmpSum += array[j];

                    if (tmpSum == S)
                    {
                        startLenght = i;
                        endLendght = j;
                        break;
                    }
                }
                if (endLendght != 0)
                {
                    break;
                }
            }

            //output
            if (endLendght == 0)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("NO SOLUTION SORRY :(");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.Write("{");
                for (int i = startLenght; i <= endLendght; i++)
                {
                    if (i == endLendght)
                    {
                        Console.Write("{0}", array[i]);
                    }
                    else
                    {
                        Console.Write("{0}, ", array[i]);
                    }
                }
                Console.WriteLine("}");
            }
        }
    }
}
