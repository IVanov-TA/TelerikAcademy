//(task 2) Write a program that concatenates two text files into another text file.


namespace ConcatenateTwoFilesInOne
{
    using System;
    using System.IO;
    using System.Text;

    class ConcatenateTwoFilesInOne
    {


        static void Main()
        {
            string[] FILES = { "test1.txt", "test2.txt" };
            string CONCAT_FILE = @"concatenated.txt";
            string PATH = @"..\..\files\";

            if (File.Exists(string.Concat(PATH, CONCAT_FILE)))
            {
                File.Delete(string.Concat(PATH, CONCAT_FILE));
            }

            try
            {
                for (int i = 0; i < FILES.Length; i++)
                {
                    using (StreamReader opener = new StreamReader(string.Concat(PATH, FILES[i]), Encoding.GetEncoding("windows-1257")))
                    {
                        string extractedText = opener.ReadToEnd();
                        WriteToFile(extractedText, string.Concat(PATH, CONCAT_FILE));
                    }
                }
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Sorry no such file!\n{0}", fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("Invalid Directory !\n{0}", dnfe.Message);
            }
        }

        static void WriteToFile(string textReaded, string pathToFile)
        {
            using (StreamWriter writeToFile = new StreamWriter(pathToFile, true, Encoding.GetEncoding("windows-1257")))
            {
                writeToFile.WriteLine(textReaded);
            }
        }
    }
}
