namespace SubstringExtensionMethod
{
    using System;
    using System.Text;

    public class Testing
    {
        public static void Main()
        {
            StringBuilder test = new StringBuilder();
            test.Append("ThereIsNoRules");
            System.Console.WriteLine(test.SubstringBuilder(4, 5));
        }
    }
}
