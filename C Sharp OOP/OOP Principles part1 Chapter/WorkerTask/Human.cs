namespace WorkerTask
{
    using System;

    /// <summary>
    /// Human class.
    /// </summary>
    public abstract class Human : IHuman
    {
        /// <summary>
        /// Human first name field.
        /// </summary>
        private string firtsName;

        /// <summary>
        /// Human last name field.
        /// </summary>
        private string lastName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
        /// </summary>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Second name.</param>
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Gets the name of the customer.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this.firtsName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid First Name");
                }

                this.firtsName = value;
            }
        }

        /// <summary>
        /// Gets the second name value.
        /// </summary>
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid Last Name");
                }

                this.lastName = value;
            }
        }

        /// <summary>
        /// Human class ToString method.
        /// </summary>
        /// <returns>First and Last name.</returns>
        public override string ToString()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
