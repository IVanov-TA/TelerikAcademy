namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : IComment
    {
        private static List<string> uniqueTextIdentifierCheck = new List<string>();

        private string uniqueTextIdentifier;
        private List<Student> studentList;
        private List<Teacher> teacherList;

        public Class(string textIdentifier, Student student, Teacher teacher)
        {
            // add unique class ID
            this.UniqueTextIdentifier = textIdentifier;
            Class.uniqueTextIdentifierCheck.Add(textIdentifier);

            // add student
            this.studentList = new List<Student>();
            this.AddStudent(student);

            // add teacher
            this.teacherList = new List<Teacher>();
            this.AddTeacher(teacher);
        }

        public string StudentList
        {
            get
            {
                return string.Join("\n", this.studentList);
            }
        }

        public string TeacherList
        {
            get
            {
                return string.Join("\n", this.teacherList);
            }
        }

        /// <summary>
        /// Gets the UniqueClassID
        /// </summary>
        public string UniqueTextIdentifier
        {
            get
            {
                return this.uniqueTextIdentifier;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class ID can not be empty");
                }

                if (Class.uniqueTextIdentifierCheck.Contains(value))
                {
                    throw new DuplicateWaitObjectException("Class ID already exists");
                }

                this.uniqueTextIdentifier = value;
            }
        }

        #region IComment Members

        /// <summary>
        /// Gets or sets the Class optional comments
        /// </summary>
        public string Comment { get; set; }

        #endregion

        public void AddStudent(Student student)
        {
            this.studentList.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacherList.Add(teacher);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Class: " + this.UniqueTextIdentifier);
            sb.AppendLine(new string('-', 30));
            sb.AppendFormat("Teacher List: \n\n{0}\n", this.TeacherList);
            sb.AppendLine(new string('-', 30));
            sb.AppendFormat("Student List: \n\n{0}\n", this.StudentList);
            return sb.ToString();
        }
    }
}