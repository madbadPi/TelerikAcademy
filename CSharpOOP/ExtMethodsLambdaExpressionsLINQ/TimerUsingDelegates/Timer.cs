namespace TimerUsingDelegates
{
    using System;
    using System.Threading;

    public class Timer
    {
        public static void TimerMethod(Action f)
        {
            while (true)
            {
                Thread.Sleep(200);
                f();
            }
        }
    }    

    public class Test
    {
        static void Main()
        {
            Action t = new Action(() => Console.WriteLine("Hello"));
            Timer.TimerMethod(t);            
        }
    }
}

