/*(task 3) We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualElementSequence
{
    class EqualElementSequence
    {
        static void Main(string[] args)
        {
            string[,] matrix = new string[,]
            { 
                {"ha", "mi", "ha", "hi"},
                {"xi", "ha", "xi", "hi"},
                {"xa", "mi", "ha", "hi"},
                {"xi", "xi", "ha", "ha"},
                {"xi", "ma", "ha", "hua"}
            };
            int row, col;
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].PadLeft(5, ' '));
                }
                Console.WriteLine();
            }


            //solution

            int counter = 1;
            int rowInMatrix = 0;
            int colInMatrix = 0;
            int bestCount = 1;


            //horizontal check
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col + 1 == matrix.GetLength(1))
                    {
                        break;
                    }

                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        if (bestCount < counter)
                        {
                            bestCount = counter;
                            rowInMatrix = row;
                            colInMatrix = col;
                        }
                        counter = 1;
                    }

                }
                if (bestCount < counter)
                {
                    bestCount = counter;
                    rowInMatrix = row;
                    colInMatrix = col;
                }
            }

            //vertical check
            counter = 1;
            for (col = 0; col < matrix.GetLength(1); col++)
            {
                counter = 1;
                for (row = 0; row < matrix.GetLength(0); row++)
                {
                    if (row + 1 == matrix.GetLength(0))
                    {
                        break;
                    }

                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        counter++;
                    }
                    else
                    {
                        if (bestCount < counter)
                        {
                            bestCount = counter;
                            rowInMatrix = row;
                            colInMatrix = col;
                        }
                        counter = 1;
                    }
                }
                if (bestCount < counter)
                {
                    bestCount = counter;
                    rowInMatrix = row;
                    colInMatrix = col;
                }
            }

            counter = 0;


            //diagonal check (down and right) && (up and right)
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (col = 0; col < matrix.GetLength(1); col++)
                {

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        if (row + i == matrix.GetLength(0) || col + i == matrix.GetLength(1))
                        {
                            break;
                        }
                        if (matrix[row, col] == matrix[row + i, col + i])
                        {
                            counter++;
                            if (counter > bestCount)
                            {
                                bestCount = counter;
                                rowInMatrix = row;
                                colInMatrix = col;
                            }
                        }
                    }
                    counter = 0;

                    for (int i = 0; i < matrix.GetLength(1); i++)
                    {
                        if (row - i < 0 || col + i == matrix.GetLength(1))
                        {
                            break;
                        }

                        if (matrix[row,col] == matrix[row,col])
                        {
                            counter++;
                            if (bestCount < counter)
                            {
                                bestCount = counter;
                                rowInMatrix = row;
                                colInMatrix = col;
                            }
                        }
                    }
                    counter = 0;
                }
            }

            //output
            Console.WriteLine(bestCount);
            for (int i = 0; i < bestCount; i++)
            {
                Console.Write("{0} ", matrix[rowInMatrix, colInMatrix]);
            }
            Console.WriteLine();
        }
    }
}
