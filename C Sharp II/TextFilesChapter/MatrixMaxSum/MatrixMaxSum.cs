//(task 5) Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:

namespace MatrixMaxSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    class MatrixMaxSum
    {
        static void Main()
        {
            StreamReader readFile = new StreamReader(@"..\..\files\matrix.txt");

            try
            {
                using (readFile)
                {
                    int N = int.Parse(readFile.ReadLine());
                    int[,] matrix = new int[N, N];

                    string line;
                    int matrixLine = 0;

                    while ((line = readFile.ReadLine()) != null)
                    {
                        string[] tmpStr = line.Split(' ');

                        for (int i = 0; i < tmpStr.Length; i++)
                        {
                            matrix[matrixLine, i] = int.Parse(tmpStr[i]);
                        }

                        matrixLine++;
                    }

                    CalculateBestMatrix(matrix);
                }
            }
            catch (FileNotFoundException er)
            {
                Console.WriteLine("File {0} NOT FOUND", er.FileName.Substring(er.FileName.LastIndexOf('\\') + 1));
            }
        }
        static void CalculateBestMatrix(int[,] matrix)
        {
            int bestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int tmpSum = 0;
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            tmpSum += matrix[row + i, col + j];
                        }
                    }
                    if (tmpSum > bestSum)
                    {
                        bestSum = tmpSum;
                    }
                }
            }

            Console.WriteLine("BestSum: {0}", bestSum);
        }
    }
}
