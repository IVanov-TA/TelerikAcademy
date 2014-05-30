namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class School
    {
        private List<Class> allClasses;

        public School(string schoolName, params Class[] currentClass)
        {
            this.SchoolName = schoolName;
            this.allClasses = new List<Class>();
            this.allClasses.AddRange(currentClass);
        }

        public string SchoolName { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("School Name: " + this.SchoolName);

            foreach (var currentClass in this.allClasses)
            {
                sb.AppendLine(currentClass.ToString());
            }

            return sb.ToString();
        }
    }
}
