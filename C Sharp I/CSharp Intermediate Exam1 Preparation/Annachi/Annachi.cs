using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annachi
{
    class Annachi
    {
        static void Main(string[] args)
        {
            char fir = char.Parse(Console.ReadLine());
            char sec = char.Parse(Console.ReadLine());

            int first = fir - 64;
            int second = sec - 64;
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine((char)(first + 64));

            for (int i = 2; i <= lines; i++)
            {

                Console.Write((char)(second + 64));
                Console.Write(new string(' ', i - 2));
                int third = second + first;
                if (third > 26)
                {
                    third = third % 26;
                }
                Console.Write((char)(third + 64));
                Console.WriteLine();
                first = third;
                second = third + second;
                if (second > 26)
                {
                    second = second % 26;
                }
            }
        }
    }
}
