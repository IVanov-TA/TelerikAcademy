//(task 18)Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractingEmail
{
    class ExtractingEmail
    {
        static void Main()
        {
            string text = "lil@yahoo.com is not the same as lil@gmail.com as well as lil@abv.bg";
            string regex = @"\w+@\w+\.\w+";

            foreach (var item in Regex.Matches(text, regex))
            {
                Console.WriteLine(item);
            }
        }
    }
}
