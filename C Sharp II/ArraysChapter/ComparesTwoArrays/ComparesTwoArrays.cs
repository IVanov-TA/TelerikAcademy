//(Task 2) Write a program that reads two arrays from the console and compares them element by element.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparesTwoArrays
{
    class ComparesTwoArrays
    {
        static void Main(string[] args)
        {
            //ask for array lenght and initialize the array1
            Console.Write("Please enter the lenght for the first array = ");
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];

            //fill the array with values
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("Enter value for array1[{0}] = ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            //ask for second array lenght and initialize the second array
            Console.Write("Please enter the lenght for the second array = ");
            n = int.Parse(Console.ReadLine()); ;
            int[] array2 = new int[n];

            //fill array2 with values
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("Enter value for array2[{0}] = ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }

            //initiliaze the bool value for equivalent of two arrays
            bool isEqual = true;

            //check if the arrays lenght is equal
            if (array1.Length == array2.Length)
            {
                //check if arrays values are equal
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        isEqual = false;
                    }
                }
            }
            else
            {
                isEqual = false;
            }

            //printing the result
            Console.WriteLine("The two arrays are {0} !", isEqual ? "Equal" : "Not Equal");

        }
    }
}
