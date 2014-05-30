//(Task 10)A marketing firm wants to keep record of its employees. Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string employeeFirstName = "Ivan";
            string employeeFamilyName = "Petkanov";
            byte age = 26;
            char gender = 'm';
            int employeeId = 12121;
            short uniqueNum = 9999;//assign it with 27560000 + uniqueNum
            Console.WriteLine("Personal Data Information: \nFirst Name: {0} \nFamily Name: {1}\nAge: {2} \nGender: {3}\nID: {4}\nEmployee Number: {5}", employeeFirstName, employeeFamilyName, age, gender, employeeId, 27560000 + uniqueNum);
        }
    }
}
