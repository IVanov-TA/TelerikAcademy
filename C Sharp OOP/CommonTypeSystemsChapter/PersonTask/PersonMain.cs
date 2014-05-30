namespace PersonTask
{
    using System;

    public class PersonMain
    {
        public static void Main()
        {
            Person pesho = new Person("pesho");

            Console.WriteLine(pesho);

            Person gosho = new Person("Gosho", 28);
            Console.WriteLine(gosho);
        }
    }
}
