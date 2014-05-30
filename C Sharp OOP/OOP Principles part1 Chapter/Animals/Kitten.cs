namespace Animals
{
    using System;

    /// <summary>
    /// Kitten class
    /// </summary>
    public class Kitten : Cat, ISound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kitten"/> class
        /// </summary>
        /// <param name="name">kitten's name</param>
        /// <param name="age">kitten's age</param>
        /// gender will always be female
        public Kitten(string name, int age)
            : base(name, age, false)
        {
        }

        /// <summary>
        /// Kitten's sound method
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("I'm kitten");
        }
    }
}
