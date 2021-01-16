using System;
using System.Threading;
using System.Threading.Tasks;

namespace testTaskCompletionSource
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     var tcs = new TaskCompletionSource<int>();

        //     new Thread(() =>
        //     {
        //         Thread.Sleep(5000);
        //         tcs.SetResult(42);
        //     })
        //     {
        //         IsBackground = true
        //     }.Start();

        //     Task<int> task = tcs.Task;
        //     System.Console.WriteLine(task.Result);
        // }

        // // 使用 TaskCompletionSource 实现Task.Run的效果
        // static void Main(string[] args)
        // {
        //     Task<int> task = Run(() =>
        //     {
        //         Thread.Sleep(5000);
        //         return 42;
        //     });

        //     System.Console.WriteLine(task.Result);
        // }

        // // 调用此方法相当于调用 Task.Factory.StartNew，
        // // 并使用 TaskCreationOptions.LongRunning 选项来创建非线程池的线程
        // static Task<TResult> Run<TResult>(Func<TResult> function)
        // {
        //     var tcs = new TaskCompletionSource<TResult>();

        //     new Thread(() =>
        //     {
        //         try
        //         {
        //             tcs.SetResult(function());
        //         }
        //         catch (System.Exception ex)
        //         {
        //             tcs.SetException(ex);
        //         }
        //     }).Start();

        //     return tcs.Task;
        // }

        // // timer 例子
        // static void Main(string[] args)
        // {
        //     var awaiter = GetAnswerToLife().GetAwaiter();
        //     awaiter.OnCompleted(() =>
        //     {
        //         System.Console.WriteLine(awaiter.GetResult());
        //     });
        //     Console.ReadKey();
        // }

        // static Task<int> GetAnswerToLife()
        // {
        //     var tcs = new TaskCompletionSource<int>();
        //     var timer = new System.Timers.Timer(5000) { AutoReset = false };
        //     timer.Elapsed += delegate
        //     {
        //         timer.Dispose();
        //         tcs.SetResult(42);
        //     };
        //     timer.Start();
        //     return tcs.Task;
        // }

        // // Delay 例子
        // static void Main(string[] args)
        // {
        //     // 5 秒钟之后，Continuation 开始的时候，才占用线程
        //     Delay(5000).GetAwaiter().OnCompleted(() =>
        //     {
        //         System.Console.WriteLine(42);
        //     });
        //     Console.ReadKey();
        // }

        // static Task Delay(int milliseconds)
        // {
        //     // 没有非泛型版本的TaskCompletionSource
        //     var tcs = new TaskCompletionSource<object>();
        //     var timer = new System.Timers.Timer(milliseconds) { AutoReset = false };
        //     timer.Elapsed += delegate
        //     {
        //         timer.Dispose();
        //         tcs.SetResult(null);
        //     };
        //     timer.Start();
        //     return tcs.Task;
        // }

        static void Main(string[] args)
        {
            Task.Delay(5000)
                .GetAwaiter()
                .OnCompleted(() => System.Console.WriteLine(42));

            Task.Delay(5000)
                .ContinueWith(a => System.Console.WriteLine(42));

            Console.ReadKey();
        }
    }
}
