using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadronacci
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());
            double fourt = double.Parse(Console.ReadLine());
            double rows = double.Parse(Console.ReadLine());
            double cols = double.Parse(Console.ReadLine());
            double nextNum = 0;
            Console.Write("{0} {1} {2} {3} ", first, second, third, fourt);
            int count = 0;
            for (int i = 0; i < cols - 4; i++)
            {
                count++;
                nextNum = first + second + third + fourt;
                first = second;
                second = third;
                third = fourt;
                fourt = nextNum;
                if ((count - (cols - 4)) == 0)
                {
                    Console.Write(nextNum);
                }
                else
                {
                    Console.Write(nextNum + " ");
                }

            }
            Console.WriteLine();
            count = 0;
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    count++;
                    nextNum = first + second + third + fourt;
                    first = second;
                    second = third;
                    third = fourt;
                    fourt = nextNum;
                    if ((count - cols)  == 0)
                    {
                        Console.Write(nextNum);
                    }
                    else
                    {
                        Console.Write(nextNum + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
