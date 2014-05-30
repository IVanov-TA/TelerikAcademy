/*(task 9) Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumInArr
{
    class MostFrequentNumInArr
    {
        static void Main(string[] args)
        {
            //input
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int number = int.MinValue;
            int times = 0;


            //solution
            for (int i = 0; i < array.Length; i++)
            {
                int tmp = i;
                int count = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == tmp)
                    {
                        count++;
                    }
                }
                if (times < count)
                {
                    times = count;
                    number = tmp;
                }
            }
            
          //output
            Console.WriteLine("{0} ({1} times)", number, times);
        }
    }
}
