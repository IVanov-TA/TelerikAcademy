namespace Animals
{
    /// <summary>
    /// Abstract Animal class
    /// </summary>
   public abstract class Animal : ISound
   {
       #region CONSTRUCTOR
       /// <summary>
       /// Initializes a new instance of the <see cref="Animal"/> class
       /// </summary>
       /// <param name="name">animal name</param>
       /// <param name="age">animal age</param>
       /// <param name="isMale">animal gender</param>
       public Animal(string name, int age, bool isMale)
       {
           this.Name = name;
           this.Age = age;
           this.IsMale = isMale;
       }
       #endregion

       #region PROPERTIES
       /// <summary>
       /// Gets the animal name
       /// </summary>
       public string Name { get; private set; }

       /// <summary>
       /// Gets the animal age
       /// </summary>
       public int Age { get; private set; }

       /// <summary>
       /// Gets a value indicating whether animal is male or not
       /// </summary>
       public bool IsMale { get; private set; }
       #endregion

       #region METHODS
       #region ISound Members

       /// <summary>
       /// abstract method for animal sound
       /// </summary>
       public abstract void MakeSound();

        #endregion
       #endregion
    }
}
