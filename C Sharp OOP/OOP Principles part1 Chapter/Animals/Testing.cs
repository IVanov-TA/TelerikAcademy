namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Testing class
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// Testing point
        /// </summary>
        public static void Main()
        {
            Dog sharo = new Dog("Sharo", 2, true);
            Kitten kitty = new Kitten("kitty", 1);
            Tomcat tom = new Tomcat("Tom", 3);
            Frog froggy = new Frog("Froggy", 3, true);
            Cat cat = new Cat("Cat", 2, false);

            IList<Animal> kingdom = new List<Animal>();

            kingdom.Add(sharo);
            kingdom.Add(kitty);
            kingdom.Add(tom);
            kingdom.Add(froggy);
            kingdom.Add(cat);

            var averageAge = kingdom.Average(x => x.Age);

            Console.WriteLine("Average age of kingdom is: {0:0.00} y", averageAge);

            Console.WriteLine();

            foreach (var animal in kingdom)
            {
                Console.Write("{0} said: ", animal.Name);
                animal.MakeSound();
            }
        }
    }
}
