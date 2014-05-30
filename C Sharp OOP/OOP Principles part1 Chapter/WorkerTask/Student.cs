namespace WorkerTask
{
    using System;

    /// <summary>
    /// Student class.
    /// </summary>
    public class Student : Human, IHuman
    {
        /// <summary>
        /// Student grade.
        /// </summary>
        private int grade;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">Student first name.</param>
        /// <param name="lastName">Student last name.</param>
        /// <param name="studentGrade">Student grade.</param>
        public Student(string firstName, string lastName, int studentGrade)
            : base(firstName, lastName)
        {
            this.Grade = studentGrade;
        }

        /// <summary>
        /// Gets Student's grade.
        /// </summary>
        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("Student invalid grade");
                }

                this.grade = value;
            }
        }

        /// <summary>
        /// Student to string method.
        /// </summary>
        /// <returns>Student first, last name and student's grade.</returns>
        public override string ToString()
        {
            return string.Format("Student: {0,-20} Grade: {1}", base.ToString(), this.Grade);
        }
    }
}
