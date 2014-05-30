namespace Animals
{
    using System;

    /// <summary>
    /// Tomcat class
    /// </summary>
    public class Tomcat : Cat, ISound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tomcat"/> class
        /// </summary>
        /// <param name="name">tomcat's name</param>
        /// <param name="age">tomcat's age</param>
        /// tomcat is always a male gender
        public Tomcat(string name, int age)
            : base(name, age, true)
        {
        }

        /// <summary>
        /// Tomcat's sound method
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Miaoo I'm a BIG Tomcat");
        }
    }
}
