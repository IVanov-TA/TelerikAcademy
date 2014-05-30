//(task 3) Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

namespace LineNumberedText
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class LineNumberedText
    {
        static void Main()
        {
            string pathToFIles = @"..\..\files\";
            string fileToOpen = "sample.txt";
            try
            {
                using (StreamReader opener = new StreamReader(string.Concat(pathToFIles, fileToOpen)))
                {
                    string line = opener.ReadLine();
                    int lineNum = 1;

                    using (StreamWriter writer = new StreamWriter(string.Concat(pathToFIles, "sampleNumbered.txt")))
                    {
                        while (line != null)
                        {
                            writer.WriteLine("Line number {0}: {1}", lineNum, line);
                            lineNum++;
                            line = opener.ReadLine();
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not FOUND");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Invalid DIRECTORY");
            }
            catch (Exception)
            {
                Console.WriteLine("Something gone realy BAD !!!");
            }
        }
    }
}
