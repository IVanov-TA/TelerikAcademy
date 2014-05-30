//*(Task 12) Write a program to read your age from the console and print how old you will be after 10 years.

using System;

namespace PrintAge
{
    class PrintAge
    {
        static void Main()
        {
            DateTime inp = DateTime.Now; //Set up datetime
            string yearStr = string.Format("{0:yyyy}", inp); //convert year to string

            int userDateOfBirth = (int.Parse(Console.ReadLine()) - int.Parse(yearStr)) * (-1); //calculate user year of birth

            DateTime afterTenYears = inp.AddYears(10);//new variable holding 10 years from today
            Console.WriteLine("After 10 years you will be: {0}", afterTenYears.Year - userDateOfBirth); //calculating the result 
            Console.WriteLine();
        }
    }
}
