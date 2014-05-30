//(task 1) Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillMatrixSizeN
{
    class FillMatrixSizeN
    {
        static void Main(string[] args)
        {
            //input
            Console.Write("Please Enter matrix size: ");
            int size;

            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.Write("Please Enter matrix size:");
            }

            string[,] matrix = new string[size, size];

            //solutions


            // a) task
            int counter = 1;

            for (int col = 0; col < size; col++)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = counter.ToString();
                    counter++;
                }

            }
            //output
            Console.WriteLine("a)");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col].PadLeft(4, ' '));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            // b) task
            counter = 1;
            string direction = "down";
            int currentRow = -1;
            int currentCol = 0;

            while (true)
            {
                if (counter == (size * size) + 1)
                {
                    break;
                }

                if (direction == "down")
                {
                    currentRow++;
                    if (currentRow == size)
                    {
                        direction = "up";
                        currentCol++;
                        continue;
                    }


                }
                else
                {
                    currentRow--;
                    if (currentRow < 0)
                    {
                        direction = "down";
                        currentCol++;
                        continue;
                    }

                }
                matrix[currentRow, currentCol] = counter.ToString();
                counter++;
            }

            //output
            Console.WriteLine("b)");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col].PadLeft(4, ' '));

                }
                Console.WriteLine();
            }
            Console.WriteLine();



            // c) task
            counter = 1;
            currentCol = 0;
            int line = size - 1;
            int column = 1;

            while (counter < size * size + 1)
            {
                if (line < 0)
                {
                    line = 0;
                }

                currentRow = line;

                while (currentRow < size && currentCol < size)
                {

                    matrix[currentRow, currentCol] = counter.ToString();
                    counter++;
                    currentRow++;
                    currentCol++;
                }

                line--;

                if (currentCol == size)
                {
                    currentCol = column;
                    column++;
                }
                else
                {
                    currentCol = 0;
                }
            }

            //output
            Console.WriteLine("c)");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col].PadLeft(4, ' '));
                }
                Console.WriteLine();
            }


            //d*)
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = " ";
                }
            }
            
            currentCol = 0;
            currentRow = 0;
            counter = 1;
            matrix[currentRow, currentCol] = counter.ToString();

            int upRow = 0;
            int leftRow = 1;
            int downRow = size - 1;
            int rightCol = size - 1;

            while (counter < size * size)
            {

                while (currentRow != downRow)
                {
                    if (counter == size * size)
                    {
                        break;
                    }

                    currentRow++;
                    counter++;
                    matrix[currentRow, currentCol] = counter.ToString();

                }
                downRow--;

                while (currentCol != rightCol)
                {
                    if (counter == size * size)
                    {
                        break;
                    }

                    currentCol++;
                    counter++;
                    matrix[currentRow, currentCol] = counter.ToString();

                }
                rightCol--;

                while (currentRow != upRow)
                {
                    if (counter == size * size)
                    {
                        break;
                    }

                    currentRow--;
                    counter++;
                    matrix[currentRow, currentCol] = counter.ToString();

                }
                upRow++;

                while (currentCol != leftRow)
                {
                    if (counter == size * size)
                    {
                        break;
                    }

                    currentCol--;
                    counter++;
                    matrix[currentRow, currentCol] = counter.ToString();

                }
                leftRow++;
            }


            //output
            Console.WriteLine("d)");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col].PadLeft(4, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
