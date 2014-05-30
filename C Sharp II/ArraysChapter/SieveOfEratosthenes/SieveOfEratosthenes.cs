//(task 15)Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {

            //input

            //initiliaze the array till 1000001 because we start from zero and in task we are asked to start from 1 till 10000000
            int[] primeNumbers = new int[10000001];

            for (int i = 0; i < primeNumbers.Length; i++)
            {
                primeNumbers[i] = i;
            }

            //solution   /we wont print zeros/
            
            //set value of array[1] = 1 to array[1] = 0
            primeNumbers[1] = 0;

            //seive of Erathosthenes
            for (int i = 2; i < Math.Sqrt(primeNumbers.Length); i++)
            {
                if (primeNumbers[i] != 0)
                {
                    for (int j = i * 2; j < primeNumbers.Length; j += i)
                    {
                        //if its on position for the prime number we change its value to zero
                        primeNumbers[j] = 0;
                    }
                }
            }


            //printing the result
            foreach (var item in primeNumbers)
            {
                //check for the 0 in the array(the zeros are prime numbers)
                if (item != 0)
                {
                    Console.Write("{0} | ", item);
                }
            }
            Console.WriteLine();

        }
    }
}
