using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHPvariables
{
    class PHP
    {
        public static string ReadInput()
        {
            string currenLine = Console.ReadLine().Trim(); ;

            StringBuilder phpCode = new StringBuilder();

            while (currenLine != "?>")
            {
                phpCode.AppendLine(currenLine);
                currenLine = Console.ReadLine().Trim();
            }
            return phpCode.ToString();
        }

        public static bool IsValidVariableSymbol(char symbol)
        {
            if (char.IsLetterOrDigit(symbol) || symbol == '_')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static HashSet<string> ExtractWords(string inputCode)
        {
            HashSet<string> allVariables = new HashSet<string>();
            StringBuilder currentVariable = new StringBuilder();

            bool inOneLineComment = false;
            bool multiLineComments = false;
            bool inSingleQuoteString = false;
            bool inDoubleQuoteString = false;
            bool inVariable = false;


            for (int i = 0; i < inputCode.Length; i++)
            {
                char currentSymbol = inputCode[i];

                //we are in one line comment
                if (inOneLineComment)
                {
                    if (currentSymbol == '\n')
                    {
                        inOneLineComment = false;
                        continue;
                    }
                    else
                    {
                        //move to next char OneLineCommnet
                        continue;
                    }
                }

                //we are in MultiLineCommnet

                if (multiLineComments)
                {
                    if (currentSymbol == '*'
                        && i + 1 < inputCode.Length
                        && inputCode[i + 1] == '/')
                    {
                        multiLineComments = false;
                        i++; //next symbol is checked
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (inVariable)
                {
                    if (IsValidVariableSymbol(currentSymbol))
                    {
                        currentVariable.Append(currentSymbol);
                        continue;
                    }
                    else
                    {
                        if (currentVariable.Length > 0)
                        {
                            allVariables.Add(currentVariable.ToString());
                        }

                        currentVariable.Clear();
                        inVariable = false;
                    }
                }
                //in single quotes
                if (inSingleQuoteString)
                {
                    if (currentSymbol == '\'')
                    {
                        inSingleQuoteString = false;
                        continue;
                    }
                }

                //in double quoted string
                if (inDoubleQuoteString)
                {
                    if (currentSymbol == '\"')
                    {
                        inDoubleQuoteString = false;
                        continue;
                    }
                }

                if (!inSingleQuoteString && !inDoubleQuoteString)
                {
                    //starting one line comment with #
                    if (currentSymbol == '#')
                    {
                        inOneLineComment = true;
                    }

                    //string one line comment with //
                    if (currentSymbol == '/'
                        & i + 1 < inputCode.Length
                        && inputCode[i + 1] == '/')
                    {
                        inOneLineComment = true;
                        i++;
                        continue;
                    }

                    //starting multilane comment
                    if (currentSymbol == '/' && i + 1 < inputCode.Length && inputCode[i + 1] == '*')
                    {
                        multiLineComments = true;
                        i++;
                        continue;
                    }
                }
                else
                {
                    //in string and next symbol is escaped
                    if (currentSymbol == '\\')
                    {
                        i++;
                        continue;
                    }
                }
                if (currentSymbol == '\'')
                {
                    inSingleQuoteString = true;
                    continue;
                }
                if (currentSymbol == '"')
                {
                    inDoubleQuoteString = true;
                }
                if (currentSymbol == '$')
                {
                    inVariable = true;
                    continue;
                }
            }
            return allVariables;
        }

        public static void PrintResult(HashSet<string> result)
        {
            Console.WriteLine(result.Count);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            string inputCode = ReadInput();
            var result = ExtractWords(inputCode);

            PrintResult(result);
        }
    }
}
