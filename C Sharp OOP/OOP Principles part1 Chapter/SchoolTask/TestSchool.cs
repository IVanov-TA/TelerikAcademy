namespace SchoolTask
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// TestSchool class
    /// </summary>
    public class TestSchool
    {
        /// <summary>
        /// Testing the whole thing :)
        /// </summary>
        public static void Main()
        {
            Teacher[] firstSchoolTeachers = 
            {
                new Teacher("Ivan", new Discipline("Math", 5, 7), new Discipline("Astronomy", 3, 5)),
                new Teacher("Pesho", new Discipline("Phisics", 4, 4)),
                new Teacher("Drago", new Discipline("Englis", 7, 5)),
                new Teacher("Miroslava", new Discipline("Rusian", 8, 7)),
                new Teacher("Petia", new Discipline("Portugees", 5, 8), new Discipline("Mandarin", 9, 9))
            };

            // auto inserting some comments
            foreach (var teacher in firstSchoolTeachers)
            {
                teacher.Comment = teacher.Name + " is best at " + teacher.DisciplineSet[0].NameOfDiscipline;
            }

            Student[] firstSchoolStudents =
            {
                new Student("Marincho", 2),
                new Student("Pencho", 3),
                new Student("Gencho", 5),
                new Student("Ivelina", 7),
                new Student("Galia", 6),
                new Student("Petiq", 1),
            };

            firstSchoolStudents[0].Comment = "Poor Student";
            firstSchoolStudents[4].Comment = "Excellent Student";

            // initialize the new Class 
            Class firstSchoolClass = new Class("3B", firstSchoolStudents[0], firstSchoolTeachers[0]);

            // add all students in class
            for (int i = 1; i < firstSchoolStudents.Length; i++)
            {
                firstSchoolClass.AddStudent(firstSchoolStudents[i]);
            }

            // add all teacher in this class
            for (int i = 1; i < firstSchoolTeachers.Length; i++)
            {
                firstSchoolClass.AddTeacher(firstSchoolTeachers[i]);
            }

            School firstSchool = new School("FirstSchool", firstSchoolClass);

            Console.WriteLine(firstSchool);
        }
    }
}
