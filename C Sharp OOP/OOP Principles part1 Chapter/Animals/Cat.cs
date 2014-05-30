namespace Animals
{
    using System;

    /// <summary>
    /// Cat class
    /// </summary>
    public class Cat : Animal, ISound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class
        /// </summary>
        /// <param name="name">cat's name</param>
        /// <param name="age">cat's age</param>
        /// <param name="isMale">cat's gender</param>
        public Cat(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        /// <summary>
        /// Cat's sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Miaoooo");
        }
    }
}
