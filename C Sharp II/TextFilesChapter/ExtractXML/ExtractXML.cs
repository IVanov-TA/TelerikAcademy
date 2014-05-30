//(task 10)Write a program that extracts from given XML file all the text without the tags. Example:


namespace ExtractXML
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class ExtractXML
    {
        static void Main()
        {
            string fileName = @"..\..\files\file.txt";

            using (StreamReader reader = new StreamReader(fileName))
            {
                bool isOutOfXMLTag = false;
                bool newLine = false;
                int readLetter = 0;
                while ((readLetter = reader.Read()) != -1)
                {
                    if (readLetter == '>')
                    {
                        isOutOfXMLTag = true;
                    }
                    if (readLetter == '<')
                    {
                        isOutOfXMLTag = false;
                        newLine = true;
                    }
                    if (isOutOfXMLTag && readLetter != '>' && readLetter != '\r' && readLetter != '\n')
                    {
                        if (newLine)
                        {
                            Console.WriteLine();
                            newLine = false;
                        }
                        Console.Write((char)readLetter);
                    }
                }
                Console.WriteLine("\n");
            }

            //open file directly :)
            Process openFile = new Process();
            openFile.StartInfo.FileName = fileName;
            openFile.Start();
        }
    }
}
