namespace SchoolTask
{
    using System;

    /// <summary>
    /// People class
    /// </summary>
    public abstract class People : IPeople
    {
        /// <summary>
        /// name field
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="People"/> class 
        /// </summary>
        /// <param name="name">name parameter</param>
        public People(string name)
        {
            this.Name = name;
        }

        #region IPeople Members

        /// <summary>
        /// Gets the Name
        /// </summary>
        public string Name
        {
            get 
            {
                return this.name;
            }

            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be empty");
                }

                this.name = value;
            }
        }

        #endregion
    }
}
