namespace SchoolTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Teacher class
    /// </summary>
    public class Teacher : People, IPeople, IComment
    {
        /// <summary>
        /// teacher disciplines set
        /// </summary>
        private List<Discipline> disciplineSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="Teacher"/> class
        /// </summary>
        /// <param name="name">teacher name</param>
        /// <param name="disciplines">teacher discipline</param>
        public Teacher(string name, params Discipline[] disciplines)
            : base(name)
        {
            this.disciplineSet = new List<Discipline>();
            this.disciplineSet.AddRange(disciplines);
        }

        /// <summary>
        /// Gets the Teacher's discipline list
        /// </summary>
        public List<Discipline> DisciplineSet
        {
            get
            {
                return new List<Discipline>(this.disciplineSet);
            }
        }

        #region IComment Members

        /// <summary>
        /// Gets or sets teacher's optional comment
        /// </summary>
        public string Comment { get; set; }

        #endregion

        public void AddDiscipline(Discipline d)
        {
            this.disciplineSet.Add(d);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Teacher: " + this.Name);

            foreach (var d in this.disciplineSet)
            {
                sb.AppendLine(d.ToString());
            }

            if (this.Comment != null)
            {
                sb.AppendFormat("Teacher comment: {0}", this.Comment);
            }

            sb.AppendLine();
            return sb.ToString();
        }
    }
}
