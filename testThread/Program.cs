using System;
using System.Threading;

namespace testThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread ...";

            Thread thread = new Thread(WriteY);
            thread.Name = "Y Thread ...";
            thread.Start();

            //    System.Console.Write(Thread.CurrentThread.Name);

            for (int i = 0; i < 1000; i++)
            {
                System.Console.Write("x");
            }

        }

        static void WriteY()
        {
            // System.Console.Write(Thread.CurrentThread.Name);
            for (int i = 0; i < 1000; i++)
            {
                System.Console.Write("y");
            }
        }

        // 程序运行结果
        // xxxxxxxxxxxyyyxxxxxx...xxxyyyxxxxxxxxxxyyyxxxxxx
    }
}
