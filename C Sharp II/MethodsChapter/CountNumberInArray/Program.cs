//(task 4)Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberInArray
{
    public class Program
    {
        public static int GetNumberCount(int[] array, int specificNumber)
        {
            int count = 0;

            foreach (var number in array)
            {
                if (number == specificNumber)
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {
            int[] array = { 4, 8, 2, 4, 8, 9, 3, 2, 4, 1, 2, 3, 4, 6, 7, 8, 4, 9, 0, 11, 22, 44 };
            int number = 4; //5 times is repeated in array above
            Console.WriteLine(GetNumberCount(array, number));
        }
    }
}
