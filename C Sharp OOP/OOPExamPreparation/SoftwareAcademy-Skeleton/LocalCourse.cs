using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            :base(name, teacher)
        {
            this.Lab = lab;
        }

        #region ILocalCourse Members

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Invalid lab name");
                }

                this.lab = value;
            }
        }

        #endregion

        public override void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            return base.ToString() + " Lab=" + this.Lab;
        }
    }
}
