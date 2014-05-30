//(task 6)Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillLenghtTo20
{
    class FillLenghtTo20
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(20);

            for (int i = 0; i < sb.Capacity; i++)
            {
                if (i < input.Length)
                {
                    if (input[i].ToString() != "")
                    {
                        sb.Append(input[i]);
                    }
                }
                else
                {
                    sb.Append('*');
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
