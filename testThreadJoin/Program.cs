using System;
using System.Threading;

namespace testThreadJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Go);
            t1.Start();
            t1.Join();
            System.Console.WriteLine("Thread t1 has ended");
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Y");
            }
        }

        // 程序运行结果
        // YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY
        // ...
        // YYYYYYYYYYYYYYYYYYYYYYYYYYYYYThread t1 has ended
    }
}
