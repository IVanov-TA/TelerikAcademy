//(task 1)Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSqrtInt
{
    class CalculateSqrtInt
    {
        static void Main()
        {
            Console.Write("Enter number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());
                CheckForNegativeNumber(number);
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (ArithmeticException) 
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
        static void CheckForNegativeNumber(int number)
        {
            if (number < 0)
            {
                throw new ArithmeticException();
            }
        }
    }
}
