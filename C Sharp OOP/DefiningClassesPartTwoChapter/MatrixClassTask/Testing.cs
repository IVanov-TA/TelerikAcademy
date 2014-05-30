namespace MatrixClassTask
{
    using System;

    public class Testing
    {
        public static void Main()
        {
            Matrix<int> test1 = new Matrix<int>(2, 2);
            if (test1)
            {
                Console.WriteLine("There are only zeroes.");
            }

            test1[0, 0] = 1;
            test1[0, 1] = 2;
            test1[1, 0] = 3;
            test1[1, 1] = 4;

            if (test1)
            {
                Console.WriteLine("There is number different from zero");
            }

            Matrix<int> test2 = new Matrix<int>(2, 2);
            test2[0, 0] = 5;
            test2[0, 1] = 6;
            test2[1, 0] = 7;
            test2[1, 1] = 8;

            Console.WriteLine(test1 + test2);
            Console.WriteLine(test1 - test2);
            Console.WriteLine(test1 * test2);
        }
    }
}
