namespace TimerExecutionTask
{
    using System;
    using System.Threading;

    public delegate void TimerDelegate();

    public class Timer
    {
        public static void RepeatSomeMethod(TimerDelegate method, int seconds, long durationInSeconds)
        {
            long start = 0;
            while (start <= durationInSeconds)
            {
                method();
                Thread.Sleep(seconds * 1000);
                start += seconds;
            }
        }

        // the method which will use to repeat
        public static void Print()
        {
            Console.WriteLine("This text will repeat in a few seconds!");
        }
    }
}
