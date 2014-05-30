using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\\" + new string('.', N / 2 - 1) + "|" + new string('.', N / 2 - 1) + "/");
            int middleDots = N / 2 - 2;
            for (int i = 0; i < N / 2 - 1; i++)
            {
                Console.WriteLine(new string('.', i + 1) + "\\" + new string('.', middleDots) + "|" + new string('.', middleDots) + "/" + new string('.', i + 1));
                middleDots--;
            }
            Console.WriteLine(new string('-', N / 2) + "*" + new string('-', N / 2));
            middleDots = 0;
            for (int i = N / 2 - 1; i > 0; i--)
            {
                Console.WriteLine(new string('.', i ) + "/" + new string('.', middleDots) + "|" + new string('.', middleDots) + "\\" + new string('.', i ));
                middleDots++;
            }

            Console.WriteLine("/" + new string('.', N / 2 - 1) + "|" + new string('.', N / 2 - 1) + "\\");
        }
    }
}
