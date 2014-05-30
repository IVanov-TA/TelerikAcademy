namespace Animals
{
    using System;

    /// <summary>
    /// Frog class
    /// </summary>
    public class Frog : Animal, ISound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frog"/> class
        /// </summary>
        /// <param name="name">frog's name</param>
        /// <param name="age">frog's age</param>
        /// <param name="isMale">frog's gender</param>
        public Frog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        /// <summary>
        /// Frog's sound method
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("#$%#^%$ form froggie");
        }
    }
}
