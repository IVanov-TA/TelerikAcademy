using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHTML
{
    class Program
    {
        public const string UperTagOpen = "<upper>";
        public const string LowerTagOpen = "<lower>";
        public const string ToggleTagOpen = "<toggle>";
        public const string RevTagOpen = "<rev>";
        public const string DelTagOpen = "<del>";

        public const string UperTagClose = "</upper>";
        public const string LowerTagClose = "</lower>";
        public const string ToggleTagClose = "</toggle>";
        public const string RevTagClose = "</rev>";
        public const string DelTagClose = "</del>";

        private static int DelTagOpened = 0;

        static List<string> allCommands = new List<string>();
        static List<int> revStartIndex = new List<int>();
        static StringBuilder output = new StringBuilder();

        static void Main()
        {
            ReadInput();
            Console.WriteLine(output.ToString().Trim());
        }

        private static void ReadInput()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string line = Console.ReadLine();
                int currentPosition = 0;

                while (currentPosition < line.Length)
                {

                    if (line[currentPosition] == '<')
                    {
                        string tag = GetTag(line, currentPosition);
                        ProcessTag(tag);

                        currentPosition += tag.Length - 1;
                    }
                    else
                    {
                        if (DelTagOpened == 0)
                        {
                            char symbol = line[currentPosition];

                            for (int j = allCommands.Count - 1; j >= 0; j--)
                            {
                                symbol = ApplyEffects(symbol, allCommands[j]);
                            }
                                output.Append(symbol);
                        }
                    }

                    currentPosition++;
                }
                output.AppendLine();
            }
        }

        private static void ProcessTag(string tag)
        {
            if (tag == DelTagOpen)
            {
                DelTagOpened++;
            }
            else if (tag == DelTagClose)
            {
                DelTagOpened--;
            }
            else
            {
                if (DelTagOpened == 0)
                {
                    if (tag == RevTagOpen)
                    {
                        revStartIndex.Add(output.Length);
                    }
                    else if (tag == RevTagClose)
                    {
                        int start = revStartIndex[revStartIndex.Count - 1];
                        int end = output.Length - 1;
                        Reverse(start, end);
                        revStartIndex.Remove(revStartIndex.Count - 1);
                    }
                    else if (tag[1] == '/')
                    {
                        allCommands.RemoveAt(allCommands.Count - 1);
                    }
                    else
                    {
                        allCommands.Add(tag);
                    }
                }
            }
        }

        private static void Reverse(int start, int end)
        {

            while (start < end)
            {
                char s = output[end];
                output[end] = output[start];
                output[start] = s;
                start++;
                end--;
            }
        }

        private static char ApplyEffects(char symbol, string command)
        {
            if (char.IsLetter(symbol))
            {
                if (command == UperTagOpen)
                {
                    symbol = char.ToUpper(symbol);
                }
                else if (command == LowerTagOpen)
                {
                    symbol = char.ToLower(symbol);
                }
                else if (command == ToggleTagOpen)
                {
                    if (char.IsLower(symbol))
                    {
                        symbol = char.ToUpper(symbol);
                    }
                    else
                    {
                        symbol = char.ToLower(symbol);
                    }
                }
            }
            
            return symbol;
        }
        private static string GetTag(string line, int position)
        {
            string tag = string.Empty;
            int start = position;
            int end = line.IndexOf('>', start + 1);
            tag = line.Substring(start, end - start + 1);
            return tag;
        }

    }
}
