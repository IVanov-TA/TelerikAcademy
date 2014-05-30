using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            :base(name, teacher)
        {
            this.Town = town;
        }

        #region IOffsiteCourse Members

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid town name");
                }

                this.town = value;
            }
        }

        #endregion

        public override void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            return base.ToString() + " Town=" + this.Town;
        }
    }
}
