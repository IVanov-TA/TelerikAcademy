//Write a program that calculates N!/K! for given N and K (1<K<N).


using System;
using System.Numerics;

namespace FaktorielNandK
{
    class FaktorielNandK
    {
        static void Main(string[] args)
        {
            string strNum;
            int n;
            int k;
            do
            {
                Console.Write("Please, enter an integer number n > 1: ");
            }
            while (!int.TryParse(strNum = Console.ReadLine(), out n) || n < 1);

            do
            {
                Console.Write("Please, enter an integer number k < n: ");
            }
            while (!int.TryParse(strNum = Console.ReadLine(), out k) || k > n);
            
            BigInteger faktorielN = 1;
            BigInteger faktorielK = 1;
            BigInteger result;

            while (n > 0) 
            {
                faktorielN *= n;
                n--;
            }
            while (k > 0)
            {
                faktorielK *= k;
                k--;
            }
            ;
            Console.WriteLine("{0} / {1} = {2}",faktorielN,faktorielK,result = faktorielN / faktorielK);
        }
    }
}
