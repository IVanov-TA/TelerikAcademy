namespace InheritanceAndPolymorphism.Interfaces
{
    using System;
    using System.Linq;

    public interface ICourse
    {
        string CourseName { get; set; }

        string TeacherName { get; set; }

        void AddStudents(params string[] studentNames);

        string ToString();
    }
}
