/*(task 4)Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchedArray
{
    class BinarySearchedArray
    {
        static void Main(string[] args)
        {
            Console.Write("Eneter array lenght: ");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the K value: ");
            int K = int.Parse(Console.ReadLine());

            //solution
            Array.Sort(array);

            //printing the sorted array
            Console.Write("Sorted array ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
            int index = Array.BinarySearch(array, K);

            //output
            if (array[0] > K)
            {
                Console.WriteLine("There is no number smaller or equal to the K!");
            }
            else
            {
                if (index > 0)
                {
                    Console.WriteLine("The number is {0} on position {1} in array", array[index], index);
                }
                else
                {
                    Console.WriteLine("Nearest smaller number to K is {0} on position {1}",array[~index - 1], ~index - 1);
                }
            }
           
            Console.WriteLine();
        }
    }
}
