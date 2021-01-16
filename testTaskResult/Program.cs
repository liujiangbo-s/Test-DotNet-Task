using System;
using System.Threading;
using System.Threading.Tasks;

namespace testTaskResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() =>
            {
                System.Console.WriteLine("Hello World");
                Thread.Sleep(3000);
                return 1;
            });

            int result = task.Result;
            System.Console.WriteLine(result);
        }

        // 结果
        // Hello World
        // 1
    }
}
