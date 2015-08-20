/*
Problem 7. Timer
• Using delegates write a class  Timer  that can execute certain method at each  t  seconds.
*/

namespace Timer
{
    using System;

    public delegate void Timer(DateTime param);
    class MainProgram
    {
        public static void TimeNow (DateTime param)
        {
            Console.WriteLine(param);
        }
        static void Main()
        {
            Timer timer = new Timer(TimeNow);
            int t = new int();
            t = 7000; //miliseconds

            while (true)
            {
                timer(DateTime.Now);
                System.Threading.Thread.Sleep(t);
            }
        }
    }
}
