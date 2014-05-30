using System;
using System.Collections.Generic;
using System.Linq;
/** Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4*/

using System.Text;
using System.Threading.Tasks;

namespace TrailingZeros
{
    class TrailingZeros
    {
        static void Main(string[] args)
        {
            int N, sum = 0, divisor = 5;
            do
            {
                Console.Write("Number N: ");
            } while (!int.TryParse(Console.ReadLine(), out N));
            do
            {
                sum += (N / divisor);
                divisor *= 5;
            } while (divisor < N);
            Console.WriteLine("There are {0} zeros in faktoriel {1}",sum, N);
        }
    }
}
