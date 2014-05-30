using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private string name;
        protected ICollection<string> topics;
        public Course(string name, ITeacher teacher = null)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
        }

        #region ICourse Members

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid course name");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }

        public abstract void AddTopic(string topic);

        #endregion

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat("{0}: Name={1};", this.GetType().Name, this.name);
            if (this.Teacher != null)
            {
                output.AppendFormat(" Teacher={0};", this.Teacher);
            }

            if (this.topics.Count > 0)
            {
                output.AppendFormat(" Topics=[{0}]; ", string.Join(", ", this.topics));
            }

            return output.ToString();
        }
    }
}
