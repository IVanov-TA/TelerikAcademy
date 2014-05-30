using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            //solution
            int startPos = 0;
            int endPosition = N;
            while (true)
            {
                for (int row = 0; row < N; row++)
                {
                    for (int col = startPos; col < endPosition; col++)
                    {
                        matrix[row, col] = 1;
                        matrix[N - 1 - row, col] = 1;
                    }
                    startPos++;
                    endPosition--;
                    if (startPos > endPosition)
                    {
                        matrix[row, startPos - 1] = 1;
                        break;
                    }
                }
                break;
            }

            //output
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
