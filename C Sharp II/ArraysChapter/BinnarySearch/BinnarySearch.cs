/*(task 11) Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinnarySearch
{
    class BinnarySearch
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 5, 7, 9, 3, 1, 4, 11 };
            int searchedNum = 7;


            //selection sort
            int min, tmp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
            foreach (var item in array)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();



            //binary search
            int mid = 0;
            int startPoint = 0;
            int endPoint = array.Length;
            int? result = null;

            while (startPoint <= endPoint)
            {
                mid = (startPoint + endPoint) / 2;

                if (array[mid] < searchedNum)
                {
                    startPoint = mid + 1;
                    continue;
                }
                if (array[mid] > searchedNum)
                {
                    endPoint = mid - 1;
                    continue;
                }
                if (array[mid] == searchedNum)
                {
                    result = mid;
                    break;
                }
            }

            Console.WriteLine("\nYou are looking for number {0}  AND i say:", searchedNum);
            if (result != null)
            {
                Console.WriteLine("The number you are looking for is on position {0}",result);
            }
            else
            {
                
                Console.WriteLine("There is no such number in the array :)\n");
            }
            
        }
    }
}
