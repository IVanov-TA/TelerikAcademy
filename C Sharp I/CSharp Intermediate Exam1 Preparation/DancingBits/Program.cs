using System;

class Program
{
    static void Main()
    {
        //input
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string concatenated = "";
        int result = 0;
        //solution
        for (int i = 0; i < N; i++)
        {
            int value = int.Parse(Console.ReadLine());
            concatenated += Convert.ToString(value, 2);
        }

        int ones = 0;
        int zeros = 0;
        int dancingBits = 0;

        for (int i = 0; i < concatenated.Length; i++)
        {
            if (concatenated[i] == '1')
            {
                if (zeros == K)
                {
                    dancingBits++;

                }
                zeros = 0;
                ones++;
            }
            if (concatenated[i] == '0')
            {
                if (ones == K)
                {
                    dancingBits++;
                }
            }
            ones = 0;
            zeros++;
            if (i == concatenated.Length - 1)
            {
                if (zeros == K)
                {
                    dancingBits++;
                }
                if (ones == K)
                {
                    dancingBits++;
                }
            }

        }

        //Console.WriteLine(concatenated);

        //output
        Console.WriteLine(dancingBits);
    }
}

