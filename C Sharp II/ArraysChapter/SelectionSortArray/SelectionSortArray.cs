//(task 7)Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortArray
{
    class SelectionSortArray
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 2, 1, 9, 8, 4, 0 };

            int min, temp;


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
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }



            //printing the result
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write("{0} ", array[k]);
            }
            Console.WriteLine();
        }
    }
}
