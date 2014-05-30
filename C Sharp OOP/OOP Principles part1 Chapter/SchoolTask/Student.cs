namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Student class
    /// </summary>
    public class Student : People, IPeople, IComment
    {
        private static List<int?> uniqueClassNumChecker = new List<int?>();

        /// <summary>
        /// student unique class number
        /// </summary>
        private int? uniqueClassNum = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class
        /// </summary>
        /// <param name="name">student name</param>
        /// <param name="number">student number</param>
        public Student(string name, int number)
            : base(name)
        {
            this.UniqueClassNum = number;
            Student.uniqueClassNumChecker.Add(number);
        }

        /// <summary>
        /// Gets the Student number
        /// </summary>
        public int? UniqueClassNum
        {
            get
            {
                return this.uniqueClassNum;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Student number must not be empty");
                }

                if (Student.uniqueClassNumChecker.Contains(value))
                {
                    throw new DuplicateWaitObjectException("Student number already exists");
                }

                this.uniqueClassNum = value;
            }
        }

        #region IComment Members

        /// <summary>
        /// Gets or sets the student optional comment
        /// </summary>
        public string Comment { get; set; }

        #endregion
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Student Name: {0} - ID: {1} {2}", this.Name, this.UniqueClassNum, this.Comment != null ? "- Student comment: " + this.Comment : string.Empty);

            return sb.ToString();
        }
    }
}
