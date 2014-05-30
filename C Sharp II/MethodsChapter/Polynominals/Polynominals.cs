﻿//(task 11) Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynominals
{
    class Polynominals
    {
        static void Main()
        {
            decimal[] first = new decimal[] { 3, -1, 4, -3, -2 };
            decimal[] second = new decimal[] { 8, 1, 3 };

            Console.WriteLine("First polynomial: " + PolyToString(first));
            Console.WriteLine("Second polynomial: " + PolyToString(second));

            //Sum
            decimal[] sum = AddPoly(first, second);
            Console.WriteLine("\n" + "Sum: "+ PolyToString(sum));

            //Substraction
            decimal[] substr = SubstrPoly(first, second);
            Console.WriteLine("\n" + "Substraction: "+ PolyToString(substr));

            //Multiplication
            decimal[] multiply = MultiplyPoly(first, second);
            Console.WriteLine("\n" + "Multiplication: "+ PolyToString(multiply));
        }

        private static decimal[] MultiplyPoly(decimal[] first, decimal[] second)
        {
            decimal[] result = new decimal[first.Length + second.Length];

            for (int i = 0; i < first.Length; i++)
            {
                for (int y = 0; y < second.Length; y++)
                {
                    result[i + y] = result[i + y] + first[i] * second[y];
                }
            }

            return result;
        }

        //substract polynomials
        private static decimal[] SubstrPoly(decimal[] first, decimal[] second)
        {
            decimal[] newPolynomial = new decimal[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < first.Length; i++)
            {
                newPolynomial[i] = first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                newPolynomial[i] = newPolynomial[i] - second[i];
            }

            return newPolynomial;
        }

        //Sum polynomials
        private static decimal[] AddPoly(decimal[] first, decimal[] second)
        {
            decimal[] newPolynomial = new decimal[Math.Max(first.Length, second.Length)];

            for (int i = 0; i < first.Length; i++)
            {
                newPolynomial[i] = first[i];
            }

            for (int i = 0; i < second.Length; i++)
            {
                newPolynomial[i] = newPolynomial[i] + second[i];
            }

            return newPolynomial;
        }

        //for printing polynomial
        private static string PolyToString(decimal[] polynomial)
        {
            StringBuilder returnString = new StringBuilder();

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0)
                {
                    returnString.Append(polynomial[i] > 0 ? " + " : " - ");
                    returnString.Append(Math.Abs(polynomial[i]));
                    if (i != 0)
                    {
                        returnString.Append(i > 1 ? "x^" + i : "x");
                    }
                }
            }

            if (returnString[1] != '-')
            {
                returnString.Remove(0, 3);
            }
            else
            {
                returnString.Remove(0, 1);
            }

            return returnString.ToString();
        }
    }
}
