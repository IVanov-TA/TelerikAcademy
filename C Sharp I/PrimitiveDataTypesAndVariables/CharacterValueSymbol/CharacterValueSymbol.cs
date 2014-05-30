//Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

using System;

namespace CharacterValueSymbol
{
    class CharacterValueSymbol
    {
        static void Main()
        {
            char letter = '\u0048'; //hex representation of int 72
            Console.WriteLine(letter);
        }
    }
}
