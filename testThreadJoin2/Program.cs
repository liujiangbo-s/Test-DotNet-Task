using System;
using System.Threading;

namespace testThreadJoin2
{
    class Program
    {
        static Thread thread1, thread2;

        static void Main(string[] args)
        {
            thread1 = new Thread(ThreadProc);
            thread1.Name = "thread1";
            thread1.Start();

            thread2 = new Thread(ThreadProc);
            thread2.Name = "thread2";
            thread2.Start();
        }

        static void ThreadProc()
        {
            System.Console.WriteLine("\nCurrent Thread {0}", Thread.CurrentThread.Name);

            System.Console.WriteLine("Thread2 State : {0}", thread2.ThreadState);

            if (Thread.CurrentThread.Name == "thread1" &&
                thread2.ThreadState != ThreadState.Unstarted)
            {
                if (thread2.Join(2000))
                {
                    System.Console.WriteLine("Thread2 has termminated.");
                }
                else
                {
                    System.Console.WriteLine("The timeout has elapsed and Thread1 will resume.");
                }
            }

            System.Console.WriteLine("\nCurrent Thread : {0}", Thread.CurrentThread.Name);
            System.Console.WriteLine("Thread1 State : {0}", thread1.ThreadState);
            System.Console.WriteLine("Thread2 State : {0}", thread2.ThreadState);
        }

        // 程序运行结果
        // Current Thread thread2

        // Current Thread thread1
        // Thread2 State : WaitSleepJoin
        // Thread2 State : Running

        // Current Thread : thread2
        // Thread1 State : WaitSleepJoin
        // Thread2 State : Running
        // Thread2 has termminated.

        // Current Thread : thread1
        // Thread1 State : Running
        // Thread2 State : Stopped
    }
}
