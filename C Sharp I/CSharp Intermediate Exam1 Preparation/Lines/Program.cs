using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            checked
            {
                int[,] matrix = new int[8, 8];

                for (int row = 0; row < 8; row++)
                {
                    int value = Math.Abs(int.Parse(Console.ReadLine()));
                    string strVal = Convert.ToString(value, 2).PadLeft(8, '0');
                    for (int col = 0; col < 8; col++)
                    {
                        matrix[row, col] = int.Parse(strVal[col].ToString());
                    }
                }

                int bestCount = 0;
                int countLines = 0;
                int counter = 0;
                int maxCount = 0;

                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        if (matrix[row, col] == 1)
                        {
                            counter++;
                        }
                        else
                        {
                            if (bestCount < counter)
                            {
                                bestCount = counter;
                            }

                            counter = 0;
                        }
                    }
                    if (bestCount < counter)
                    {
                        bestCount = counter;
                    }
                    if (maxCount <= bestCount)
                    {
                        if (maxCount < bestCount)
                        {
                            countLines = 1;
                        }
                        else
                        {
                            countLines++;
                        }
                        maxCount = bestCount;
                    }
                    bestCount = 0;
                    counter = 0;
                }

                counter = 0;
                for (int col = 0; col < 8; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {
                        if (matrix[row, col] == 1)
                        {
                            counter++;
                        }
                        else
                        {
                            if (bestCount < counter)
                            {
                                bestCount = counter;
                            }

                            counter = 0;
                        }
                    }
                    if (bestCount < counter)
                    {
                        bestCount = counter;
                    }
                    if (maxCount <= bestCount)
                    {
                        if (maxCount < bestCount)
                        {
                            countLines = 1;
                        }
                        else
                        {
                            countLines++;
                        }
                        maxCount = bestCount;

                    }
                    bestCount = 0;
                    counter = 0;
                }



                //output

                //for (int row = 0; row < 8; row++)
                //{
                //    for (int col = 0; col < 8; col++)
                //    {
                //        Console.Write(matrix[row, col]);
                //    }
                //    Console.WriteLine();
                //}
                if (maxCount == 0)
                {
                    countLines = 0;
                }
                if (maxCount == 1)
                {
                    countLines = 1;
                }
                Console.WriteLine(maxCount);
                Console.WriteLine(countLines);
            }
        }
    }
}