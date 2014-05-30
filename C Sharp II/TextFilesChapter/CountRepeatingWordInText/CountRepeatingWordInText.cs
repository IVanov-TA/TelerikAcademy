using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace CountRepeatingWordInText
{
    class CountRepeatingWordInText
    {
        static void Main()
        {
            string fileSourcePath = @"..\..\files\test.txt";
            string fileResultPath = @"..\..\files\result.txt";
            string fileDictionaryPath = @"..\..\files\words.txt";

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {
                using (StreamReader reader = new StreamReader(fileDictionaryPath, Encoding.GetEncoding("utf-8")))
                {
                    while (!reader.EndOfStream)
                    {
                        string word = reader.ReadLine();
                        dictionary.Add(word, 0);
                    }
                }

                using (StreamReader reader = new StreamReader(fileSourcePath, Encoding.GetEncoding("utf-8")))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        List<string> wordList = new List<string>(dictionary.Keys);

                        foreach (string word in wordList)
                        {
                            string regex = String.Format("\\b{0}\\b", word);
                            MatchCollection matches = Regex.Matches(line, regex);
                            dictionary[word] += matches.Count;
                        }
                    }
                }

                using (StreamWriter writer = new StreamWriter(fileResultPath, false, Encoding.GetEncoding("utf-8")))
                {
                    foreach (var wordCounter in dictionary.OrderByDescending(key => key.Value))
                    {
                        writer.Write(wordCounter.Key);
                        writer.Write("-");
                        writer.WriteLine(wordCounter.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("io operation error!");
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
            catch (RegexMatchTimeoutException ex)
            {
                Console.WriteLine("error while trying to count word!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
