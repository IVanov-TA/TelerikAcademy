//(task 14)Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAlg
{
    class QuickSortAlg
    {
        public static void Execute(IComparable[] sortArray,
                           int leftIndex,
                           int rightIndex)
        {
            int leftPointer = leftIndex;
            int rightPointer = rightIndex;

            // pick a pivot value somewhere in the middle.
            IComparable pivot = sortArray[(leftIndex + rightIndex) / 2];

            // Loop until pointers meet on the pivot.
            while (leftPointer <= rightPointer)
            {
                // find a larger value to the right of the pivot.
                //  if there is non we end up at the pivot.
                while (sortArray[leftPointer].CompareTo(pivot) < 0)
                {
                    leftPointer++;
                }

                //  find a smaller value to the left of the pivot.
                //   if there is non we end up at the pivot.
                while (sortArray[rightPointer].CompareTo(pivot) > 0)
                {
                    rightPointer--;
                }

                //  Check if both pointers are not on the pivot.
                if (leftPointer <= rightPointer)
                {
                    // Swap both values to the right side.
                    IComparable swap = sortArray[leftPointer];
                    sortArray[leftPointer] = sortArray[rightPointer];
                    sortArray[rightPointer] = swap;

                    leftPointer++;
                    rightPointer--;
                }
            }


            if (leftIndex < rightPointer)
            {
                Execute(sortArray, leftIndex, rightPointer);
            }

            if (leftPointer < rightIndex)
            {
                Execute(sortArray, leftPointer, rightIndex);
            }


        }

        static void Main(string[] args)
        {

            //input
            string[] array = { "b", "f", "g", "c", "a", "e", "d" };

            //solution
            Execute(array, 0, array.Length - 1);

            //output
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }


    }
}


