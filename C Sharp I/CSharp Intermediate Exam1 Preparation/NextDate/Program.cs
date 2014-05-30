using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace NextDate
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

            DateTime today = new DateTime(year, month, day);

            today = today.AddDays(1);
            Console.WriteLine(today.ToString("d.M.yyyy"));
        }
    }
}
