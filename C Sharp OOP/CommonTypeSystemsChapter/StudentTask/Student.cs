namespace StudentTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        #region CONSTRUCTOR
        public Student(string firstName, string middleName, string lastName, int ssn, string address, string phoneNum, string email, int course, Speciality speciality, University university, Facultie facultie)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = address;
            this.PhoneNumber = phoneNum;
            this.Email = email;
            this.Course = course;
            this.Speciality = speciality;
            this.Univeristy = university;
            this.Facultie = facultie;
        }
        #endregion

        #region PROPERTIES
        public string FirstName { get; set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public int Ssn { get; private set; }

        public string PermanentAddress { get; private set; }

        public string PhoneNumber { get; private set; }

        public string Email { get; private set; }

        public int Course { get; private set; }

        public Speciality Speciality { get; private set; }

        public University Univeristy { get; private set; }

        public Facultie Facultie { get; private set; }

        #endregion

        #region METHODS

        public static bool operator ==(Student firtsStudent, Student secondStudent)
        {
            return Student.Equals(firtsStudent, secondStudent);
        }

        public static bool operator !=(Student firtsStudent, Student secondStudent)
        {
            return !Student.Equals(firtsStudent, secondStudent);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName).AppendLine();
            sb.AppendLine(this.Ssn.ToString()).AppendLine(this.PermanentAddress).AppendLine(this.PhoneNumber).AppendLine(this.Email).AppendLine(this.Course.ToString()).AppendLine(this.Speciality.ToString()).AppendLine(this.Univeristy.ToString()).AppendLine(this.Facultie.ToString());
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.Ssn.GetHashCode();
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;

            if (student == null)
            {
                return false;
            }

            var comparisons = new List<Func<Student, object>>
                {
                    x => x.FirstName,
                    x => x.MiddleName,
                    x => x.LastName,
                    x => x.Ssn,
                    x => x.PermanentAddress,
                    x => x.PhoneNumber,
                    x => x.Email,
                    x => x.Course,
                    x => x.Facultie,
                    x => x.Univeristy,
                    x => x.Speciality
                };

            var result = comparisons.All(x => x(this).Equals(x(student)));

            return result;
        }

        #region ICloneable Members

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.PermanentAddress, this.PhoneNumber, this.Email, this.Course, this.Speciality, this.Univeristy, this.Facultie);
        }


        #endregion

        #region IComparable<Student> Members

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return (this.FirstName.CompareTo(student.FirstName));
            }

            if (this.MiddleName != student.MiddleName)
            {
                return (this.MiddleName.CompareTo(student.MiddleName));
            }

            if (this.LastName != student.LastName)
            {
                return (this.LastName.CompareTo(student.LastName));
            }

            if (this.Ssn != student.Ssn)
            {
                return (this.Ssn.CompareTo(student.Ssn));
            }

            return 0;
        }

        #endregion

        #endregion
    }
}
