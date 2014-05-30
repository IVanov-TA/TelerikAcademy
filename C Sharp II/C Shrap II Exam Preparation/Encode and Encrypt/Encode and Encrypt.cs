using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encode_and_Encrypt
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();

            Console.WriteLine(Encode(Encrypt(message, cypher) + cypher) + cypher.Length);
        }

        private static string Encode(string text)
        {
            var result = new StringBuilder();

            if (text.Length == 0)
            {
                return result.ToString();
            }
            
            int counter = 0;
            int tmpCH = text[0];

            for (int i = 0; i < text.Length; i++)
            {
               
                char tmpChar;
                if (i + 1 < text.Length && text[i] == text[i + 1])
                {
                    tmpChar = text[i];
                    counter ++;
                    i++;
                    while (i < text.Length && text[i] == tmpChar)
                    {
                        counter++;
                        i++;
                    }

                    if (counter > 2)
                    {
                        result.Append(counter).Append(tmpChar);
                        i--;
                    }
                    else
                    {
                        result.Append(tmpChar, counter);
                        i--;
                    }

                    counter = 0;
                }
                else
                {
                    result.Append(text[i]);
                }

            }
            return result.ToString();
        }

        private static string Encrypt(string message, string cypher)
        {
            StringBuilder result = new StringBuilder();
            char[] newmsg = message.ToCharArray();
            int maxLenght = Math.Max(message.Length, cypher.Length);

            if (message.Length > cypher.Length)
            {
                for (int i = 0; i < maxLenght; i++)
                {
                    int messageIndex = i % message.Length;
                    int cypherIndex = i % cypher.Length;
                    char coded = (char)(((newmsg[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
                    newmsg[messageIndex] = coded;
                    result.Append(coded);
                }
            }
            else
            {
                for (int i = 0; i < maxLenght; i++)
                {
                    int messageIndex = i % message.Length;
                    int cypherIndex = i % cypher.Length;
                    char coded = (char)(((newmsg[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
                    newmsg[messageIndex] = coded;
                }
                result.Append(newmsg);
            }

            return result.ToString();
        }
    }
}
