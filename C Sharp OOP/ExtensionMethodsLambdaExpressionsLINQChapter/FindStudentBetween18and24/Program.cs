namespace FindStudentBetween18and24
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var students = new[]
            {
                new { FirstName = "Pesho", LastName = "Peshev", Age = 17 },
                new { FirstName = "Gosho", LastName = "Peshev", Age = 19 },
                new { FirstName = "Mosho", LastName = "Doshev", Age = 18 },
                new { FirstName = "Kaloqn", LastName = "Genev", Age = 24 },
                new { FirstName = "Miro", LastName = "Petakov", Age = 25 },
            };

            // task 04
            var resultStudents = from student in students
                                 where student.Age >= 18 && student.Age <= 24
                                 select new { firstName = student.FirstName, lastName = student.LastName };

            foreach (var student in resultStudents)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }

            // task 5
            var sortedStudents = students.OrderByDescending(stud => stud.FirstName).ThenByDescending(stud => stud.LastName);

            Console.WriteLine("Sorted with Lambda expression:\n");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }

            var sortedStudentsLINQ = from student in students
                                     orderby student.FirstName descending, student.LastName descending
                                     select new { FirstName = student.FirstName, LastName = student.LastName };

            Console.WriteLine("\nSorted with LINQ:\n");
            foreach (var student in sortedStudentsLINQ)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }
}
