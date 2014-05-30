namespace StringWithMaximumLenghtTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] strArr = { "Pesho", "Marianski", "Galin", "Conko" };

            var result =
                from str in strArr
                orderby str.Length descending
                select str;

            Console.WriteLine(result.First());
        }
    }
}
