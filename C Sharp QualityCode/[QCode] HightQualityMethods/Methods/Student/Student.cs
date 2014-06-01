namespace Methods.Students
{
    using System;

    public class Student
    {
        private const string FirstNameNullOrEmptyException = "First name can not be empty";
        private const string LastNameNullOrEmptyException = "Last name can not be empty";
        private const string OtherInfoNullOrEmptyxception = "Info must not be emtpy";
        private const string BirthDateNullOrEmptyException = "Birthday can not be empty";
        private const string BirthDateRangeException = "Birthdate must be in the range [{0}; {1}]";

        private string firstName;
        private string lastName;
        private string otherInfo;
        private DateTime birthDate;

        public Student(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(FirstNameNullOrEmptyException);
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(LastNameNullOrEmptyException);
                }

                this.lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                DateTime beginningDateTime = new DateTime(1900, 1, 1);
                DateTime endDateTime = DateTime.Now;

                if (!(value >= beginningDateTime && value <= endDateTime))
                {
                    throw new ArgumentException(string.Format(
                                                              BirthDateRangeException,
                                                              beginningDateTime.ToShortDateString(),
                                                              endDateTime.ToShortDateString()));
                }

                this.birthDate = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(OtherInfoNullOrEmptyxception);
                }

                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            return this.birthDate < other.birthDate;
        }
    }
}

/*
------ StyleCop 4.7 (build 4.7.49.0) started ------


------ StyleCop completed ------

========== Violation Count: 0 ==========
*/