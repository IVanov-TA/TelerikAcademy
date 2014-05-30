//(Task 8)Declare two string variables and assign them with following value:The "use" of quotations causes difficulties. Do the above in two different ways: with and without using quoted strings.

using System;
namespace QuotationTask
{
    class QuotationTask
    {
        static void Main()
        {
            string firstString = "The \"use\" of quotations causes difficulties.";
            string secondString = "The use of quotations causes difficulties.";
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
        }
    }
}
