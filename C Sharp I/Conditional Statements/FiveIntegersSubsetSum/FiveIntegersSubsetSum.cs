//(task 9)We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveIntegersSubsetSum
{
    class FiveIntegersSubsetSum
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int a = 0; a < array.Length; a++)
            {
                array[a] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int subsetSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    sum = array[i] + array[j];
                    if (sum == 0)
                    {
                        subsetSum++;
                        Console.WriteLine("{0}+{1} ={2}", array[i], array[j], sum);
                    }
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        sum += array[k];
                        if (sum == 0)
                        {
                            subsetSum++;
                            Console.WriteLine("{0}+{1}+{2} ={3}", array[i], array[j], array[k], sum);
                        }
                        for (int l = k + 1; l < array.Length; l++)
                        {
                            sum += array[l];
                            if (sum == 0)
                            {
                                subsetSum++;
                                Console.WriteLine("{0}+{1}+{2}+{3} ={4}", array[i], array[j], array[k], array[l], sum);
                            }
                            for (int p = k + 1; p < array.Length; p++)
                            {
                                sum += array[p];
                                if (sum == 0)
                                {
                                    subsetSum++;
                                    Console.WriteLine("{0}+{1}+{2}+{3}+{4} ={5}", array[i], array[j], array[k], array[l], array[p], sum);
                                }

                            }
                        }
                    }
                }
            }
            Console.WriteLine("There are {0} subsets equal to 0", subsetSum);
        }
    }
}
