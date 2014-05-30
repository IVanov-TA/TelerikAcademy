//(task 1)Write a program that reads a text file and prints on the console its odd lines.

namespace PrintsOddLines
{
    using System;
    using System.IO;
    using System.Text;

    class PrintsOddLines
    {
        const string PATH = @"..\..\files\sample.txt";

        static void Main()
        {
            try
            {
                using (StreamReader filePath = new StreamReader(PATH, Encoding.GetEncoding("windows-1258")))
                {
                    string line = filePath.ReadLine();
                    int lineNum = 1;
                    while (line != null)
                    {
                        if (lineNum % 2 != 0)
                        {
                            Console.WriteLine(line);
                        }
                        lineNum++;
                        line = filePath.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException er)
            {
                Console.WriteLine("File: {0} is not there\n{1}", PATH, er.Message);
            }

        }
    }
}
