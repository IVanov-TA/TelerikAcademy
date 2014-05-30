/*(task 5) Write a program that finds the maximal increasing sequence in an array. Example: {6, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncresingSequence
{
    class MaximalIncresingSequence
    {
        static void Main(string[] args)
        {

            //input
            int[] array = { 0, 2, 3, 4, 1, 7, 8 };

            int endPosition = 1;
            int maxCounted = 1;
            int tmpVal = array[0];
            int tmpCounter = 1;

            //solution
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > tmpVal)
                {
                    tmpCounter++;
                    tmpVal = array[i];
                }
                else
                {
                    if (maxCounted < tmpCounter)
                    {
                        maxCounted = tmpCounter;
                        endPosition = i;
                    }

                    tmpCounter = 1;
                    tmpVal = array[i];

                }
            }


            //last check for end of the array
            if (maxCounted < tmpCounter)
            {
                maxCounted = tmpCounter;
                endPosition = array.Length;
            }

            //printing the result
            Console.Write("{");
            for (int i = maxCounted; i > 0; i--)
            {
                if (i - 1 == 0)
                {
                    Console.Write("{0}", array[endPosition - i]);
                }
                else
                {
                    Console.Write("{0},", array[endPosition - i]);
                }
            }
            Console.WriteLine("}");

        }
    }
}
