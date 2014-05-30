namespace SchoolTask
{
    using System;
    using System.Text;

    /// <summary>
    /// Discipline class
    /// </summary>
    public class Discipline : IComment
    {
        /// <summary>
        /// name field
        /// </summary>
        private string nameOfDiscipline;

        /// <summary>
        /// number of lectures filed
        /// </summary>
        private int numOfLectures;

        /// <summary>
        /// number of exercises field
        /// </summary>
        private int numOfExercises;

        /// <summary>
        /// Initializes a new instance of the <see cref="Discipline"/> class
        /// </summary>
        /// <param name="name">discipline name</param>
        /// <param name="lectureNum">numbers of lecturing</param>
        /// <param name="exercisesNum">numbers of exercises</param>
        public Discipline(string name, int lectureNum, int exercisesNum)
        {
            this.NameOfDiscipline = name;
            this.NumOfLectures = lectureNum;
            this.NumOfExercises = exercisesNum;
        }

        /// <summary>
        /// Gets or sets the name of the discipline
        /// </summary>
        public string NameOfDiscipline
        {
            get
            {
                return this.nameOfDiscipline;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Discipline name must not be empty");
                }

                this.nameOfDiscipline = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of the lectures
        /// </summary>
        public int NumOfLectures
        {
            get
            {
                return this.numOfLectures;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Incorrect number of lectures");
                }

                this.numOfLectures = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of the exercises
        /// </summary>
        public int NumOfExercises
        {
            get
            {
                return this.numOfExercises;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Incorrect number of exercises");
                }

                this.numOfExercises = value;
            }
        }

        #region IComment Members

        public string Comment { get; set; }

        #endregion

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Discipline: {0} -> Num of Lectures: {1} -> Num of Exercises: {2} {3}", this.NameOfDiscipline, this.NumOfLectures, this.NumOfExercises, this.Comment != null ? "Discipline Comment: " + this.Comment : string.Empty);

            return sb.ToString();
        }
    }
}
