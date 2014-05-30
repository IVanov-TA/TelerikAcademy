//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.


using System;

namespace CompanyTask
{
    class CompanyTask
    {
        static void Main()
        {
            int phoneNum, faxNum, age, managerPhoneNum;
            string companyName, address, webSite, firstName, lastName;
            Console.Write("Eneter Company Name: ");
            companyName = Console.ReadLine();
            Console.Write("Eneter address: ");
            address = Console.ReadLine();
            Console.Write("Eneter phone number: ");
            phoneNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter fax number ");
            faxNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eneter the website : ");
            webSite = Console.ReadLine();
            Console.Write("Eneter manager's first name: ");
            firstName = Console.ReadLine();
            Console.Write("Eneter manager's last name: ");
            lastName = Console.ReadLine();
            Console.Write("Eneter manager's phone number: ");
            managerPhoneNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Eneter manager's age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(companyName);
            Console.WriteLine(address);
            Console.WriteLine(phoneNum);
            Console.WriteLine(faxNum);
            Console.WriteLine(webSite);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(managerPhoneNum);
            Console.WriteLine(age);
        }
    }
}
