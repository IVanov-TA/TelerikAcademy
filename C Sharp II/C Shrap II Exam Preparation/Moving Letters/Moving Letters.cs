//Moving Letters

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving_Letters
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(MovingLetters(ExctractinTheLeters(input)));
        }

        private static StringBuilder ExctractinTheLeters(string[] input)
        {
            var maxLenght = 0;
            var result = new StringBuilder();
            foreach (var item in input)
            {
                if (maxLenght < item.Length)
                {
                    maxLenght = item.Length;
                }
            }
            for (int i = 0; i < maxLenght; i++)
            {
                foreach (var item in input)
                {
                    if (item.Length > i)
                    {
                        result.Append(item[item.Length - 1 - i]);
                    }
                }
            }

            return result;
        }

        private static string MovingLetters(StringBuilder sb)
        {
            StringBuilder res = new StringBuilder();
            

            for (int i = 0; i < sb.Length; i++)
            {
                char curLet = sb[i];
                int Val = char.IsLower(curLet) ? curLet - 'a' + 1 : curLet - 'A' + 1;
                int index = (Val+ i) % sb.Length;
                sb.Remove(i,1);
                sb.Insert(index, curLet);
            }
            return sb.ToString();
        }
    }
}
