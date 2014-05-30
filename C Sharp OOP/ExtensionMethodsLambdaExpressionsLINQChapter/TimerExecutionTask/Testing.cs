namespace TimerExecutionTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Testing
    {
        public static void Main()
        {
            Timer.RepeatSomeMethod(Timer.Print, 2, 10);
        }
    }
}
