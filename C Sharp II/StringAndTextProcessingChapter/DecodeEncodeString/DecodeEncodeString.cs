//(task 7)Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeEncodeString
{
    class DecodeEncodeString
    {
        static void Main()
        {
            string msg = "Hello C# world !!!";
            string cipher = "java";
            string result = DecodeEncode(msg, cipher);

            Console.WriteLine(result);
            Console.WriteLine(DecodeEncode(result, cipher));
        }

        static string DecodeEncode(string msg, string cipher)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < msg.Length; i += cipher.Length)
            {
                for (int j = 0; j < cipher.Length; j++)
                {
                    if (i + j > msg.Length - 1)
                    {
                        break;
                    }
                    char tmp = (char)(msg[i + j] ^ cipher[j]);
                    sb.Append(tmp);
                }
            }

            return sb.ToString();
        }

    }
}
