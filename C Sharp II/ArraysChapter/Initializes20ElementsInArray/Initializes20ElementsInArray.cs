//(Task 1)Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializes20ElementsInArray
{
    class Initializes20ElementsInArray
    {
        static void Main(string[] args)
        {
            //initialize the array
            int[] array = new int[20];

            
            for (int i = 0; i < array.Length; i++)
            {
                //submit value to the array index
                array[i] = i * 5;

                //printing on new line array[index] = value
                Console.WriteLine("array[{0}] = {1}", i, array[i]);
            }
        }
    }
}
