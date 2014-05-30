using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolvingTasks
{
    class SolvingTasks
    {
        public static void Menu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("1. Reverse the digits of the number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solve  linear equation of type a*x+b");
            Console.WriteLine(new string('-', 50));
            Console.Write("Please choose an option : ");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1: ReverseDigits();
                    break;
                case 2: CalculateSum();
                    break;
                case 3: LinearEquation();
                    break;
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Please Enter a valid number!");
                        Menu();
                    }
                    break;
            }
        }
        private static void ReverseDigits()
        {
            Console.Write("Please enter a number:");
            decimal myNumber = decimal.Parse(Console.ReadLine());
            string numberString = myNumber.ToString();
            if (myNumber == 0)
            {
                Console.Clear();
                Console.WriteLine("Number should be !=0. Please try again!");
                ReverseDigits();
            }
            else
            {
                Console.Write("{0} -> ", myNumber);
                for (int i = numberString.Length - 1; i >= 0; i--)
                {
                    Console.Write(numberString[i]);
                }
                Console.WriteLine();
            }
        }

        private static void CalculateSum()
        {
            Console.WriteLine("Please Enter the size of the sequence:");
            int size = int.Parse(Console.ReadLine());
            if (size == 0)
            {
                Console.Clear();
                Console.WriteLine("Number should be !=0. Please try again!");
                CalculateSum();
            }
            else
            {
                Console.WriteLine("Please Enter a sequence of numbers:");
                decimal[] myArray = new decimal[size];
                for (int i = 0; i < size; i++)
                {
                    Console.Write("num[{0}]= ", i);
                    myArray[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The Average of the sequence is: {0}", myArray.Average());

            }
        }

        private static void LinearEquation()
        {
            Console.WriteLine("Solving Linear Equation of type a*x+b=0 started! ");
            Console.Write("Please Enter a=");
            decimal aNum = decimal.Parse(Console.ReadLine());
            Console.Write("Please Enter b=");
            if (aNum == 0)
            {
                Console.Clear();
                Console.WriteLine("Number should be !=0. Please try again!");
                LinearEquation();
            }
            else
            {
                decimal bNum = decimal.Parse(Console.ReadLine());
                Console.WriteLine("The Linear equation {0}x+{1}=0 is being solved...", aNum, bNum);
                decimal x = (-bNum / aNum);
                Console.WriteLine("x={0}", x);
            }
        }

        public static void Main(string[] args)
        {
            Menu();
        }
    }
}
