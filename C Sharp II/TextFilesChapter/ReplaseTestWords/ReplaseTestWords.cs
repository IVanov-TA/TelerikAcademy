//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.

namespace ReplaseTestWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Diagnostics;

    class ReplaseTestWords
    {
        static void Main()
        {
            string input = @"..\..\files\input.txt";
            string output = @"..\..\files\output.txt";
            using (StreamReader reader = new StreamReader(input))
            {
                Console.WriteLine("Loading...");
                using (StreamWriter write = new StreamWriter(output))
                {
                    string line = reader.ReadLine(); ;

                    while (line != null)
                    {
                        write.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
                        line = reader.ReadLine();
                    }
                }
                Console.WriteLine("Ready to open files");
            }
            Process open = new Process();
            open.StartInfo.FileName = input;
            open.Start();

            open.StartInfo.FileName = output;
            open.Start();
        }
    }
}
