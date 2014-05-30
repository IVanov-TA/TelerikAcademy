//(Task 9)Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

using System;

namespace CopyrightTrianlge
{
    class CopyrightTrianlge
    {
        static void Main()
        {
            char copyRight = '\u00A9';
            int rows = 3;
            int cols = 5;
            int blankPosition = cols - (cols / 2) - 1;
            int charCount = 1;
            for (int i = 0; i < rows; i++)
            {
                Console.Write(new String(' ', blankPosition));
                for (int j = 0; j < charCount; j++)
                {
                    Console.Write(copyRight);
                }
                Console.Write(new String(' ', blankPosition));
                Console.WriteLine();
                blankPosition--;
                charCount += 2;
            }
        }
    }
}
