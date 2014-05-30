namespace GenericListTask
{
    using System;

    public class Testing
    {
        public static void Main()
        {
            GenericList<int> arr = new GenericList<int>();

            for (int i = 0; i < 64; i++)
            {
                arr.Add(i);
            }

            arr.RemoveAt(63);
            arr.InsertAt(0, 1900);
            arr.Add(777);
            arr.FindElement(999);

            Console.WriteLine(arr.Min<int>());
            Console.WriteLine(arr.Max<int>());
            Console.WriteLine(arr.Count);
            Console.WriteLine(arr.ToString());
        }
    }
}
