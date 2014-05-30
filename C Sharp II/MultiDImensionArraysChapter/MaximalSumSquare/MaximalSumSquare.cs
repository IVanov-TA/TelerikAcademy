//(task 2)Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSumSquare
{
    class MaximalSumSquare
    {
        static void Main(string[] args)
        {
            //auto input
            int N = 3;
            int M = 4;
            int[,] matrix = new int[N, M];
            byte count = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++, count++)
                {
                    matrix[row, col] = count;
                }
            }

            string digitOfMatrix = "";

            //printing the whole, filled with numbers matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++, count++)
                {
                    digitOfMatrix = matrix[row, col].ToString();
                    Console.Write(digitOfMatrix.PadLeft(4, ' '));

                }
                Console.WriteLine();
            }

            //solution
            int maxSum = int.MinValue;

            //chech if matrix is smaller than field we searching for max sum (3)
            if (N < 3 || M < 3)
            {
                Console.WriteLine("IT CAN'T BE DONE");
            }
            else
            {
                int rowOfMatrix = 0;
                int colOfMatrix = 0;
                int tmpSum = int.MinValue;

                for (int row = 0; row <= matrix.GetLength(0) - 3; row++)
                {
                    for (int col = 0; col <= matrix.GetLength(1) - 3; col++)
                    {
                        tmpSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                        if (tmpSum > maxSum)
                        {
                            maxSum = tmpSum;
                            rowOfMatrix = row;
                            colOfMatrix = col;
                        }
                        tmpSum = 0;
                    }
                }
                Console.WriteLine("\nMaximal sum 3x3 is: {0}", maxSum);
                Console.WriteLine("Matrix with max sum is: \n");

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        digitOfMatrix = matrix[rowOfMatrix + row, colOfMatrix + col].ToString();
                        Console.Write(digitOfMatrix.PadLeft(4, ' '));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
