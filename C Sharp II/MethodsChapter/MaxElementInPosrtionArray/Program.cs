//(task 09) Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxElementInPosrtionArray
{
    class Program
    {
        static int[] SortArray(int[] array1, int startArray)
        {

            int select = 0;
            int select1 = 0;
            int n = array1.Length;
            int[] array2 = new int[n];
            for (int ii = startArray; ii < n; ii++)
            {
                select = ii;
                for (int k = ii + 1; k < n; k++)
                {
                    if (array1[select] > array1[k])
                    {
                        select = k;
                    }
                }
                select1 = array1[select];
                array1[select] = array1[ii];
                array2[ii] = select1;
            }
            return array2;
        }

        static void Main()
        {
            Console.WriteLine("Enter length of array:");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            int lastElementOfArray = 0;
            Console.WriteLine("Enter elements of array:");
            array1 = aadElementsArray(n, array1);
            Console.WriteLine("Enter start array:");
            int startArray = int.Parse(Console.ReadLine());
            array2 = SortArray(array1, startArray);
            lastElementOfArray = volumeLastElementArray(array2);
            Console.WriteLine(lastElementOfArray);
        }

        private static int volumeLastElementArray(int[] array2)
        {

            return array2[array2.Length - 1];
        }

        private static int[] aadElementsArray(int n, int[] array1)
        {
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            return array1;
        }
    }
}
