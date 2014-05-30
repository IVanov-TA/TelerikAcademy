namespace WorkerTask
{
    using System;

    /// <summary>
    /// Worker class.
    /// </summary>
    public class Worker : Human, IHuman
    {
        /// <summary>
        /// Workers week salary field.
        /// </summary>
        private double workerWeekSalary;

        /// <summary>
        /// Workers worked hours per day field.
        /// </summary>
        private double workerWorkedHoursPerDay;

        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class.
        /// </summary>
        /// <param name="firstName">Worker first name.</param>
        /// <param name="lastName">Worker last name.</param>
        /// <param name="weekSalary">Worker week's salary.</param>
        /// <param name="workHoursPerDay">Working hours per day.</param>
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        /// <summary>
        /// Gets worker week salary.
        /// </summary>
        public double WeekSalary 
        {
            get
            {
                return this.workerWeekSalary;
            }

            private set
            {
                if (value < 100)
                {
                    throw new IndexOutOfRangeException("Worker said -> WTF I'm not gonna work for salary below 100");
                }

                this.workerWeekSalary = value;
            }
        }

        /// <summary>
        /// Gets worker worked hours per day.
        /// </summary>
        public double WorkHoursPerDay 
        {
            get
            {
                return this.workerWorkedHoursPerDay;
            }

            private set
            {
                if (value > 8)
                {
                    throw new IndexOutOfRangeException("Worker said -> R u insane ? <- I'm not gonna work more than 8 hours.");
                }

                this.workerWorkedHoursPerDay = value;
            }
        }

        /// <summary>
        /// Worker money per hour method.
        /// </summary>
        /// <returns>Earned money per hour by the worker.</returns>
        public double MoneyPerHour()
        {
            return (this.WeekSalary / 5) / this.WorkHoursPerDay;
        }

        /// <summary>
        /// Worker to string method.
        /// </summary>
        /// <returns>Worker first, last name and earned money per hour.</returns>
        public override string ToString()
        {
            return string.Format("Worker: {0,-20} Salary: {1:0.00}", base.ToString(), this.MoneyPerHour());
        }
    }
}
