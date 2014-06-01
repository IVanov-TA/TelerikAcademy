namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course
    {
        private string courseName;
        private string teacherName;
        private IList<string> students;

        public Course(string courseName, string teachersName)
        {
            this.CourseName = courseName;
            this.TeacherName = teachersName;
            this.students = new List<string>();
        }

        public string CourseName
        {
            get
            {
                return this.courseName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Course name cannot be null or empty");
                }

                this.courseName = value;
            }
        }

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Teacher name cannot be null or empty");
                }

                this.teacherName = value;
            }
        }

        public List<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }
        }

        public virtual void AddStudents(params string[] studentNames)
        {
            foreach (var studentName in studentNames)
            {
                if (string.IsNullOrEmpty(studentName))
                {
                    throw new ArgumentException("Student name cannot be null or empty");
                }

                this.students.Add(studentName);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {{ Name = {1}", this.GetType().Name, this.CourseName);

            if (this.TeacherName != null)
            {
                result.AppendFormat("; Teacher = {0}", this.TeacherName);
            }

            result.AppendFormat("; Students = {0}", this.GetStudentsAsString());
            result.Append(" }");

            return result.ToString();
        }

        private string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
