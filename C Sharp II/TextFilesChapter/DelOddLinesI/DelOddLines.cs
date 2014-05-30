//(task 9) Write a program that deletes from given text file all odd lines. The result should be in the same file.

namespace DelOddLinesI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class DelOddLines
    {
        static void Main()
        {
            List<string> evenLines = new List<string>();

            using (StreamReader sr = new StreamReader(@"..\..\files\test1.txt"))
            {
                string currLine;
                int count = 1;
                while ((currLine = sr.ReadLine()) != null)
                {
                    if (count % 2 == 0)
                    {
                        evenLines.Add(currLine);
                    }
                    count++;
                }
            }
            using (StreamWriter sw = new StreamWriter(@"..\..\files\test1.txt"))
            {
                foreach (var line in evenLines)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}
