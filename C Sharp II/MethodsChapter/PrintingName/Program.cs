/*(task 1) Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingName
{
    public class Program
    {
       public static string PrintName(string name)
        {
            string sentence = "Hello " + name;
            Console.WriteLine(sentence);
            return sentence;
        }


        static void Main(string[] args)
        {
            Console.Write("Please tell me your name: ");
            string userName = Console.ReadLine();
            PrintName(userName);
        }
    }
}
