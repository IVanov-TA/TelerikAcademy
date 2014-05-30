using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        private ICollection<ICourse> courses;
        private string teacherName;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        #region ITeacher Members

        public string Name
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid name");
                }

                this.teacherName = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        #endregion

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Teacher: Name={0}; ", this.Name);
            if (this.courses.Count != 0)
            {
                output.AppendFormat("Courses=[{0}]", string.Join(", ", this.courses.Select(c => c.Name)));
            }

            return output.ToString();
        }
    }
}
