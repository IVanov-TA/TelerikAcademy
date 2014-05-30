//(Task 3)Write a program that compares two char arrays lexicographically (letter by letter).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicallyCompare
{


    class LexicographicallyCompare
    {

        static void Main(string[] args)
        {
            //input

            Console.Write("Eneter firstArray lenght = ");
            int n = int.Parse(Console.ReadLine());
            char[] firstArray = new char[n];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }


            Console.Write("Eneter secondArray lenght = ");
            n = int.Parse(Console.ReadLine());
            char[] secondArray = new char[n];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            //solution
            int minLenght = Math.Min(firstArray.Length, secondArray.Length);
            bool areLexiEqual = true;
            bool breaked = false;

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        areLexiEqual = false;
                    }
                    else
                    {
                        breaked = true;
                        break;
                    }
                }
            }

            //output
            if (areLexiEqual)
            {
                if (breaked)
                {
                    Console.WriteLine("firstArray\nsecondArray");
                }
                else
                {
                    if (firstArray.Length < secondArray.Length)
                    {
                        Console.WriteLine("firstArray\nsecondArray");
                    }
                    else if (firstArray.Length > secondArray.Length)
                    {
                        Console.WriteLine("secondArray\nfirstArray");
                    }
                    else
                    {
                        Console.WriteLine("The are identic !!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("secondArray\nfirstArray");
            }
        }
    }
}
