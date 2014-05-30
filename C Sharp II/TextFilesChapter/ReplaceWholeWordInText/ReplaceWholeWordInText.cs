//(task 8)Modify the solution of the previous problem to replace only whole words (not substrings).

namespace ReplaceWholeWordInText
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Text.RegularExpressions;

    class ReplaceWholeWordInText
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(@"..\..\files\input.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"..\..\files\output.txt"))
                {
                    for (string line; (line = sr.ReadLine()) != null; )
                    {
                        sw.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    }
                }
            }
        }
    }
}
