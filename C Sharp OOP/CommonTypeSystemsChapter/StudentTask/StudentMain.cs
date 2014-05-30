namespace StudentTask
{
    using System;

    public class StudentMain
    {
        public static void Main()
        {
            Student st1 = new Student("milko", "kalav", "diev", 223, "22mo", "0896/22342", "mail@yahoo.com", 5, Speciality.Informatics, University.SU, Facultie.Telecommunications);

            Student st2 = new Student("milko", "kalav", "diev", 223, "22mo", "0896/22342", "mail@yahoo.com", 5, Speciality.Informatics, University.SU, Facultie.Telecommunications);

            Console.WriteLine(st1 == st2);

            var newStudent = st1.Clone();
            Console.WriteLine(newStudent.FirstName);
            Console.WriteLine(st1 == newStudent);

            newStudent.FirstName = "Boiko";
            Console.WriteLine(newStudent.FirstName);
            Console.WriteLine(st1.FirstName);
            Console.WriteLine(st1 == newStudent);

            Console.WriteLine(newStudent.CompareTo(st1));
        }
    }
}
