//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStringArray
{
    class SortingStringArray
    {

        static string[] SortStringArray(params string[] array)
        {
            string temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }


        static void PrintingArray(string[] array) {

            Console.WriteLine(string.Join(", ",array));
        }

        static void Main(string[] args)
        {
            //input
            string[] array = { "hello", "welcome", "bye", "go", "more" };
            //solution
            SortStringArray(array);
            //output
            PrintingArray(array);
        }
    }
}
