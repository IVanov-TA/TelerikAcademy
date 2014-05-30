//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).


using System;
using System.Numerics;

namespace FaktorielNandKFormula
{
    class FaktorielNandKFormula
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
            while (!int.TryParse(strNum = Console.ReadLine(), out k) || k < n);

            int kMinusN = k - n;
            BigInteger faktorielN = 1;
            BigInteger faktorielK = 1;
            BigInteger faktorielNK =1 ;
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
            while (kMinusN > 0)
            {
                faktorielNK *= kMinusN;
                kMinusN--;
            }
            ;
            Console.WriteLine("({0}*{1})/{2} = {3}", faktorielN, faktorielK,faktorielNK, result = (faktorielN*faktorielK)/faktorielNK);
        }
    }

}
