using System;
using System.Threading;

namespace testThreadGiveParam
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     new Thread(() => Go("hi xiao ming")).Start(); 
        // }

        // static void Go(string msg)
        // {
        //     System.Console.WriteLine(msg);
        // }

        // static void Main(string[] args)
        // {
        //     new Thread(Go).Start("hi xiao ming");
        // }

        // static void Go(object msg)
        // {
        //     System.Console.WriteLine((string)msg);
        // }

        // static void Main(string[] args)
        // {
        //     for (int i = 0; i < 5; i++)
        //     {
        //         new Thread(() => System.Console.Write(i)).Start();
        //     }
        // }

        // // 结果
        // // 55555

        // // 原因
        // // i 在循环的整个生命周期内指向的是同一个内存地址
        // // 每个线程对 Console.Write() 的调用都会在它运行的时候对它进行修改

        // static void Main(string[] args)
        // {
        //     for (int i = 0; i < 5; i++)
        //     {
        //         int temp = i;
        //         new Thread(() => System.Console.Write(temp)).Start();
        //     }
        // }

        // // 结果
        // // 01243

        // static void Main(string[] args)
        // {
        //     try
        //     {
        //         new Thread(Go).Start();
        //     }
        //     catch (System.Exception exce)
        //     {
        //         System.Console.WriteLine(exce.Message);
        //     }
        // }

        // static void Go()
        // {
        //     throw new Exception("Go 异常了");
        // }
        // // 结果
        // // Go 异常了

        static void Main(string[] args)
        {
            new Thread(Go).Start();
        }

        static void Go()
        {
            try
            {
                throw new Exception("Go 异常了");
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Go 的异常捕获到了");
            }
        }
        // 结果
        // Go 的异常捕获到了
    }
}
