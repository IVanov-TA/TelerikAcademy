using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', N - 2) + "*" + new string('.', N - 2));
            for (int i = 1; i < N - 1; i++)
            {
                Console.Write(new string('.', N - 2 - i));
                Console.Write(new string('*', i*2 + 1));
                Console.Write(new string('.', N - 2 - i));
                Console.WriteLine();
            }
            Console.WriteLine(new string('.', N - 2) + "*" + new string('.', N - 2));
        }
    }
}
