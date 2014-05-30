//(task 8)Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserChoiseInput
{
    class UserChoiceInput
    {
        static void Main(string[] args)
        {
            Console.Write("Type int, double or string: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int intValue = int.Parse(Console.ReadLine());
                    intValue += 1;
                    Console.WriteLine(intValue);
                    break;
                case "double":
                    double doubleValue = double.Parse(Console.ReadLine());
                    doubleValue += 1;
                    Console.WriteLine(doubleValue);
                    break;
                case "string":
                    string strValue = Console.ReadLine();
                    strValue += "*";
                    Console.WriteLine(strValue);
                    break;
                default:
                    Console.WriteLine("Invalid choice :(");
                    break;
            }
        }
    }
}
