using System;
using System.Threading;
using System.Threading.Tasks;

namespace testTaskException
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Task task = Task.Run(() => throw new Exception("task异常了"));

        //     try
        //     {
        //         task.Wait();
        //     }
        //     catch (System.Exception exce)
        //     {
        //         System.Console.WriteLine(exce.Message);
        //     }
        // }

        // // result
        // // One or more errors occurred. (task异常了)

        // static void Main(string[] args)
        // {
        //     Task<int> task = Task.Run(() => { throw new Exception("task<int> 异常了"); return 1; });

        //     try
        //     {
        //         int result = task.Result;
        //     }
        //     catch (AggregateException exce)
        //     {
        //         System.Console.WriteLine(exce.Message);
        //     }
        // }

        // // result
        // // One or more errors occurred. (task<int> 异常了)

        static void Main(string[] args)
        {
            TaskScheduler.UnobservedTaskException += (s, e) =>
                       {
                           System.Console.WriteLine(e.Exception);
                       };

            Task task = Task.Run(() =>
            { throw new Exception("task<int> 异常了"); });

            Console.ReadKey();

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadKey();


        }
    }
}
