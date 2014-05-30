using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telerikLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            char asteriks = '*';
            char dots = '.';
            Console.WriteLine(new string(dots, input / 2) + "*" + new string(dots, ((input / 2) * 2) + (input - 2)) + "*" + new string(dots, input / 2));
            int middleDots = ((input / 2) * 2) + (input - 2);
            int counter = 1;
            for (int i = 1; i <= input / 2; i++)
            {
                counter++;
                Console.Write(new string(dots, ((input / 2) - i)));
                Console.Write("*");
                Console.Write(new string(dots, i * 2 - 1));
                Console.Write("*");
                Console.Write(new string(dots, (middleDots - (2 * i))));
                Console.Write("*");
                Console.Write(new string(dots, i * 2 - 1));
                Console.Write("*");
                Console.Write(new string(dots, ((input / 2) - i)));
                Console.WriteLine();
            }
            for (int i = 0; i < (input - (input / 2) - 2); i++)
            {
                Console.Write(new string(dots, input + i));
                Console.Write("*");
                Console.Write(new string(dots, (input - 4) - i * 2));
                Console.Write("*");
                Console.Write(new string(dots, input + i));
                Console.WriteLine();
            }

            Console.Write(new string(dots, (input * 3 - 2) / 2));
            Console.Write(asteriks);
            Console.Write(new string(dots, (input * 3 - 2) / 2));
            Console.WriteLine();

            for (int i = 1; i < input; i++)
            {
                Console.Write(new string(dots, ((((input * 3) - 2) / 2) - i)));
                Console.Write(asteriks);
                Console.Write(new string(dots, (i * 2) - 1));
                Console.Write(asteriks);
                Console.Write(new string(dots, ((((input * 3) - 2) / 2) - i)));
                Console.WriteLine();
            }
            for (int i = 1; i < input - 1; i++)
            {
                Console.Write(new string(dots, ((input / 2) + i)));
                Console.Write("*");
                Console.Write(new string(dots,middleDots - i*2));
                Console.Write("*");
                Console.Write(new string(dots, ((input / 2) + i)));
                Console.WriteLine();
            }


            Console.Write(new string(dots, (input * 3 - 2) / 2));
            Console.Write(asteriks);
            Console.Write(new string(dots, (input * 3 - 2) / 2));
            Console.WriteLine();
        }
    }
}
