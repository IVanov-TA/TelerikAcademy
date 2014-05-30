/*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintIndexOfEachLetter
{
    class PrintIndexOfEachLetter
    {
        static void Main(string[] args)
        {
            //input

            //create new char array for the letters
            char[] charArray = new char[52];

            //fill the array
            for (int i = 0; i < charArray.Length - 26; i++)
            {
                charArray[i] = (char)(i + 64 + 1);
            }
            for (int i = 0; i < 26; i++)
            {
                charArray[i+26] = (char)(i + 1 + 96);
            }
            foreach (var item in charArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();


            //solution

            //string word = "HELLO"; test string
            //waiting for word input
            string word = Console.ReadLine();
            string[] result = new string[word.Length];
            int? currentResult = null;
            int counter = 0;

            //processing the array with binary search
            while (true)
            {
                char searchedDigit = word[counter];
                int mid;

                int startPos = 0;
                int endPos = charArray.Length;

                while (startPos <= endPos)
                {
                    mid = (startPos + endPos) / 2;
                    if (mid < charArray.Length)
                    {
                        if (charArray[mid] < searchedDigit)
                        {
                            startPos = mid + 1;
                            continue;
                        }
                        if (charArray[mid] > searchedDigit)
                        {
                            endPos = mid - 1;
                            continue;
                        }
                        if (charArray[mid] == searchedDigit)
                        {
                            currentResult = mid;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentResult != null)
                {
                    result[counter] = currentResult.ToString();
                    currentResult = null;
                }
                else
                {
                    result[counter] = "Can't FIND this...";
                }
                if (counter != word.Length - 1)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            //output
            Console.WriteLine();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine("{0}   ->    {1}", word[i], result[i]);
            }
            Console.WriteLine();
        }
    }
}
