//(task 12) Write a program that removes from a text file all words listed in given another text file. Handle all possible exceptions in your methods.


namespace RemoveListedWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Text.RegularExpressions;

    class RemoveListedWords
    {
        const string PATH = @"..\..\files\";

        static void Main()
        {
            string wordsFile = string.Concat(PATH, "words.txt");
            string textFile = string.Concat(PATH, "text.txt");
            try
            {
                using (StreamReader read = new StreamReader(wordsFile))
                {
                    string[] wordItems = read.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    using (StreamReader readText = new StreamReader(textFile))
                    {
                        string currentLine = readText.ReadLine();

                        while (currentLine != null)
                        {
                            foreach (var word in wordItems)
                            {
                                currentLine = Regex.Replace(currentLine, @"\b" + word + @"\b", String.Empty);

                            }

                            Console.WriteLine(currentLine);
                            currentLine = readText.ReadLine();
                        }

                    }

                }
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (ArgumentNullException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (OutOfMemoryException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }

}

