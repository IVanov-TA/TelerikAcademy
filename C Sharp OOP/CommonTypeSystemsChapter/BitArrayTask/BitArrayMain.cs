namespace BitArrayTask
{
    using System;

    public class BitArrayMain
    {
        public static void Main()
        {
            BitArray64 number = new BitArray64(7);

            // print bits of the ulong number
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            // make second BitArray
            BitArray64 number2 = new BitArray64(7);

            Console.WriteLine(number.Equals(number2));

            // indexer starts from young bits
            Console.WriteLine(number[2]);
            // print hash code
            Console.WriteLine(number.GetHashCode());

            // change bit
            number[8] = 1;
            // print the changed number and his bits
            Console.WriteLine(number.Number);
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();
        }
    }
}
