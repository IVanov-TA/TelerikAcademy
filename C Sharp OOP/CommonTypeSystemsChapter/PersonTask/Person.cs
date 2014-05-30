namespace PersonTask
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must not be emtpy");
                }

                this.name = value;
            }
        }

        public int? Age 
        { 
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }


        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1}", this.Name, this.Age.ToString() != string.Empty ? this.Age.ToString() : "Age is not specified");
        }
    }
}
