/*(task 4)Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:
 
        We are living in an yellow submarine. We don't have anything else. 
        Inside the submarine is very tight. So we are drinking all the day. 
        We will move out of it in 5 days.

	    The result is: 9.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainedSubstringInText
{
    class ContainedSubstringInText
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string searchingText = Console.ReadLine();
            Console.WriteLine(GetSubstringCount(text, searchingText));

        }

        static int GetSubstringCount(string text, string substring)
        {
            int count = 0;
            int index = text.IndexOf(substring, 0);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(substring, index + 1);
            }
            return count;
        }
    }
}
