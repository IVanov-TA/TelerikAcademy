using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int center = n / 2;
            int height = n / 2;
            int numOfElements = n;

            for (int i = 1; i <= height; i++)
            {
                int elPos = 1;

                while (elPos <= numOfElements)
                {
                    if ((elPos <= center - i) || (elPos > center + i))
                    {
                        Console.Write(".");
                        elPos++;

                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("/");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("\\");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                       
                    }

                }
                Console.WriteLine();
            }

            for (int i = height; i > 0; i--)
            {
                int elPos = 1;

                while (elPos <= numOfElements)
                {
                    if ((elPos <= center - i) || (elPos > center + i))
                    {
                        Console.Write(".");
                        elPos++;

                    }
                    else
                    {
                        for (int j = 0; j < i; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("\\");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                        for (int j = i; j > 0; j--)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("/");
                                elPos++;
                            }
                            else
                            {
                                Console.Write(" ");
                                elPos++;
                            }
                        }
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
