using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int height = 2 * N - 1;
            int fPart = height / 2 + 1;
            for (int i = 0; i < fPart; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', N - i - 1));
                Console.WriteLine();
            }
            int counter = 1;
            for (int i = fPart - 1; i > 0; i--)
            {
                Console.Write(new string('.', i - 1));
                Console.Write("*");
                Console.Write(new string('.', counter));
                counter++;
                Console.WriteLine();
            }
        }
    }
}
