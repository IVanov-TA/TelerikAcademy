//(task 5) Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementBiggerThanNeighbours
{
    class ElementBiggerThanNeighbours
    {
        static void CheckElement(int[] array, int position)
        {
            if (position > array.Length - 2 || position <= 0)
            {
                Console.WriteLine("Missing one neighbour\nNumber is not bigger than neigbours"); ;
            }
            else
            {
                if (array[position - 1] < array[position] && array[position + 1] < array[position])
                {
                    Console.WriteLine("Number is bigger than two neighbours {0} > {1}  && {0} > {2}", array[position], array[position - 1], array[position + 1]);
                }
                else
                {
                    Console.WriteLine("In this position number is not bigger than his neighbours");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 7, 4, 5, 6, 8, 6 };
            int position = 3;
            CheckElement(array, position);
        }
    }
}
