//(task 8)Write a program that extracts from a given text all sentences containing given word.
//		Example: The word is "in".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSenenceWithSpecificWord
{
    class ExtractSenenceWithSpecificWord
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            List<int> indecesOfwordInText = new List<int>();

            string[] sentencesArray;
            sentencesArray = text.Split('.');

            indecesOfwordInText = FindSentencesWithWord(sentencesArray, word);

            for (int i = 0; i < indecesOfwordInText.Count; i++)
            {
                Console.WriteLine((sentencesArray[(indecesOfwordInText[i])] + ".").Trim());
            }
        }

        static List<int> FindSentencesWithWord(string[] sentences, string word)
        {
            List<int> sentencesToOutput = new List<int>();

            for (int i = 0; i < sentences.Length; i++)
            {
                if (Regex.Matches(sentences[i], "\\b" + word + "\\b", RegexOptions.IgnoreCase).Count > 0)
                {
                    sentencesToOutput.Add(i);
                }
            }

            return sentencesToOutput;
        }
    }
}
