using System;
using System.Threading;

namespace testThreadSafe
{
    class Program
    {
        // 线程不安全的例子
        // static bool _done = false;

        // static void Main(string[] args)
        // {
        //     new Thread(Go).Start();

        //     Go();

        // }

        // static void Go()
        // {
        //     if (!_done)
        //     {
        //         System.Console.WriteLine("Done");

        //         Thread.Sleep(50);

        //         _done = true;
        //     }
        // }

        // // 输出结果
        // // Done
        // // Done


        // 线程安全的例子
        static bool _done = false;

        static readonly object _object = new object();

        static void Main(string[] args)
        {

            new Thread(Go).Start();

            Go();
        }

        static void Go()
        {
            lock (_object)
            {
                if (!_done)
                {
                    System.Console.WriteLine("Done");

                    Thread.Sleep(50);

                    _done = true;
                }
            }
        }

        // 结果
        // Done
    }
}
