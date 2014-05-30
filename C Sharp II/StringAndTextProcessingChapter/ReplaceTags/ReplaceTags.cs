//(task 5)You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

using System;

namespace ReplaceTags
{
    class ReplaceTags
    {
        private const string OPEN_TAG = "<upcase>";
        private const string CLOSE_TAG = "</upcase>";

        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            try
            {
                Console.WriteLine(UpTheTextInTag(text));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("You have unclosed tag in text !!!");
            }

        }

        static string UpTheTextInTag(string text)
        {
            int openTagIndex = 0;
            int closeTagIndex = 0;
            string updatedText = string.Empty;

            if ((openTagIndex = text.IndexOf(OPEN_TAG, closeTagIndex)) < 0)
            {
                text = text.Replace(CLOSE_TAG, String.Empty);
                return text;
            }
            else
            {
                closeTagIndex = text.IndexOf(CLOSE_TAG, openTagIndex);

                if (closeTagIndex < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                string tmp = text.Substring(openTagIndex + OPEN_TAG.Length, closeTagIndex - openTagIndex - OPEN_TAG.Length);
                updatedText = text.Replace(OPEN_TAG + tmp + CLOSE_TAG, tmp.ToUpper());

                return UpTheTextInTag(updatedText);
            }
        }

    }
}
