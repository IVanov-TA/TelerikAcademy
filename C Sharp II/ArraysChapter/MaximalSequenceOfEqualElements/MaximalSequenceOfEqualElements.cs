/*(task 4) Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequenceOfEqualElements
{
    class MaximalSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            //input
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int maxCount = 1;
            int value = array[0];

            int count = 1;
            int tmpVal = value;

            //solution
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == tmpVal)
                {
                    count++;
                }
                else
                {
                    if (maxCount <= count)
                    {
                        maxCount = count;
                        value = tmpVal;
                    }
                    count = 1;
                    tmpVal = array[i];
                }

            }
            //output -> printing the result
            Console.Write("{");
            for (int i = 0; i < maxCount; i++)
            {
                if (i + 1 == maxCount)
                {
                    Console.Write("{0}", value);
                }
                else
                {
                    Console.Write("{0},", value);
                }

            }
            Console.WriteLine("}");
        }
    }
}
