using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromSearching
{
    class Program
    {
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }

        static void Main()
        {
            string str = "neven  level Palindrom Expressions exe";

            foreach (Match item in Regex.Matches(str, @"\w+"))
                if (IsPalindrome(item.Value)) Console.WriteLine(item);
        }
    }
}