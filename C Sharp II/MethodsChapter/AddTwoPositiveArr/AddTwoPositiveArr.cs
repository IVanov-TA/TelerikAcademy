/*(task 8) Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoPositiveArr
{
    class AddTwoPositiveArr
    {
        static void Main()
        {
            int[] a = new int[] { 1, 9 };
            int[] b = new int[] { 9, 9, 9 };
            Print(Add(ReverseInput(a), ReverseInput(b)));
        }
        static List<int> Add(int[] a, int[] b)
        {
            List<int> result = new List<int>(b.Length + 1);
            int sum = 0;
            int convey = 0;
            int loop = 0;
            if (a.Length > b.Length)
            {
                return Add(b, a);
            }
            for (; loop < a.Length; loop++)
            {
                sum = a[loop] + b[loop] + convey;
                convey = sum / 10;
                sum %= 10;
                result.Add(sum);
            }
            for (; loop < b.Length; loop++)
            {
                sum = b[loop] + convey;
                convey = sum / 10;
                sum %= 10;
                result.Add(sum);
            }
            if (convey > 0)
            {
                result.Add(convey);
            }

            return result;
        }
        static void Print(List<int> result)
        {
            result.Reverse();
            foreach (var item in result)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static int[] ReverseInput(int[] c)
        {
            int[] reversed = new int[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                reversed[c.Length - i - 1] = c[i];
            }
            return reversed;
        }
    }
}
