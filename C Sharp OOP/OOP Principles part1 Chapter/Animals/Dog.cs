namespace Animals
{
    using System;

    /// <summary>
    /// Dog class
    /// </summary>
    public class Dog : Animal, ISound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class
        /// </summary>
        /// <param name="name">dog's name</param>
        /// <param name="age">dog's age</param>
        /// <param name="isMale">dog's gender</param>
        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {
        }

        /// <summary>
        /// Dog's sound method
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Wouuff..");
        }
    }
}
