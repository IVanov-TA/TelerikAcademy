//(task 6)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedElementBiggerThanNeighbours
{
    class ExtendedElementBiggerThanNeighbours
    {
        static int BiggerNeighborFinder(int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
                {
                    index = i;
                    break;
                }
                else
                {
                    index = -1;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 4, 7, 8 };
            Console.WriteLine(BiggerNeighborFinder(myArray));
        }
    }
}
