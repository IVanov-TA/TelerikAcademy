//(task 7)Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. Ensure it will work with large files (e.g. 100 MB).

namespace ReplaceStringsInText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class ReplaceStringsInText
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(@"..\..\files\input.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"..\..\files\output.txt"))
                {
                    for (string line; (line = sr.ReadLine()) != null; )
                    {
                        sw.WriteLine(line.Replace("start", "finish"));
                    }
                }
            }
        }
    }
}
