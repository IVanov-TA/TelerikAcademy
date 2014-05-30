namespace SortingStudentsByFirstLastName
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var students = new[]
        {
            new { FirstName = "Ivan", LastName = "Ivanov" },
            new { FirstName = "Georgi",  LastName = "Simeonov" },
            new { FirstName = "Ivan",  LastName = "Todorov" },
            new { FirstName = "Petyr",  LastName = "Chipev" },
            new { FirstName = "Anton",  LastName = "Donchev" },
            new { FirstName = "Filip",  LastName = "Andreev" },
            new { FirstName = "Svetslav",  LastName = "Bozov" },
        };
            var sorted =
                from st in students
                where st.FirstName.CompareTo(st.LastName) == -1
                select (st.FirstName + " " + st.LastName);

            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
}
