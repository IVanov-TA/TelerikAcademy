//(task 4)Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

namespace CompareTwoTextFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CompareTwoTextFiles
    {
        static void Main()
        {
            string path = @"..\..\files\";
            try
            {
                using (StreamReader readerOne = new StreamReader(string.Concat(path, "file1.txt")), readerTwo = new StreamReader(string.Concat(path, "file2.txt")))
                {
                    int countEqual = 0, countDiff = 0;
                    string readLineTxtOne, readLineTxtTwo;

                    while ((readLineTxtOne = readerOne.ReadLine()) != null && (readLineTxtTwo = readerTwo.ReadLine()) != null)
                    {
                        if (readLineTxtOne.Equals(readLineTxtTwo))
                        {
                            countEqual++;
                        }
                        else
                        {
                            countDiff++;
                        }
                    }

                    Console.WriteLine("Equal: {0}\nDifferent: {1}", countEqual, countDiff);
                }
            }
            catch (FileNotFoundException er)
            {
                Console.WriteLine("File {0} NOT FOUND", er.FileName.Substring(er.FileName.LastIndexOf('\\') + 1));
            }

        }
    }
}
