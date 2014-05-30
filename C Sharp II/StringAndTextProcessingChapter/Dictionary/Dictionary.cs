/*(task 14)A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
            .NET – platform for applications from Microsoft
            CLR – managed execution environment for .NET
            namespace – hierarchical organization of classes
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main()
        {
            List<string> words = new List<string>() { ".NET", "CLR", "namespace" };
            List<string> explanation = new List<string>() { "platform for applications from Microsoft", "managed execution environment for .NET", "hierarchical organization of classes" };
            string word = Console.ReadLine();

            int index = words.FindIndex(x => x.StartsWith(word));

            Console.WriteLine("{0} - {1}", words[index], explanation[index]);
        }
    }
}
