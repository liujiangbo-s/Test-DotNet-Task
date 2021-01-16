using System;
using System.Threading;

namespace testThreadJoinTimeSpan
{
    class Program
    {
        static TimeSpan waitTime = new TimeSpan(0, 0, 1);
        static void Main(string[] args)
        {
            Thread newThread = new Thread(Work);
            newThread.Start();

            if (newThread.Join(waitTime - waitTime))
            {
                System.Console.WriteLine("New thread terminated");
            }
            else
            {
                System.Console.WriteLine("Join timed out.");
            }
        }
        static void Work()
        {
            Thread.Sleep(waitTime);
        }

        // 输出结果
        // Join timed out.
    }
}
