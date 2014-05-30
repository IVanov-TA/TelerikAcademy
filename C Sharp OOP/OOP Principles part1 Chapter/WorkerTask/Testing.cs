namespace WorkerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Testing class.
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// Test point.
        /// </summary>
        public static void Main()
        {
            try
            {
                List<Student> listOfTenStudents = new List<Student>
            {
                new Student("Yavor", "Dachev", 4),
                new Student("Kiril", "Iliev", 8),
                new Student("Mitko", "Petkov", 5),
                new Student("Ilian", "Tachev", 8),
                new Student("Galia", "Petrova", 11),
                new Student("Sonia", "Mincheva", 21),
                new Student("Valentin", "Ignatov", 33),
                new Student("Pesho", "Peshev", 7),
                new Student("Ican", "Icanov", 332),
                new Student("Lisan", "Lisanov", 2)
            };

                var sortStudents = listOfTenStudents
                    .OrderBy(x => x.Grade);

                Console.WriteLine(string.Join("\n", sortStudents));
                Console.WriteLine();

                List<Worker> listOfTenWorkers = new List<Worker>
            {
                new Worker("Yavor", "Dachev", 100, 8),
                new Worker("Kiril", "Iliev", 200, 4),
                new Worker("Mitko", "Petkov", 190, 8),
                new Worker("Ilian", "Tachev", 170, 4),
                new Worker("Galia", "Petrova", 250, 4),
                new Worker("Sonia", "Mincheva", 350, 4),
                new Worker("Valentin", "Ignatov", 400, 7),
                new Worker("Pesho", "Peshev", 880, 3),
                new Worker("Ican", "Icanov", 400, 6),
                new Worker("Lisan", "Lisanov", 400, 5)
            };

                var sortedWorkers = listOfTenWorkers
                    .OrderByDescending(x => x.MoneyPerHour());

                Console.WriteLine(string.Join("\n", sortedWorkers));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }
    }
}
