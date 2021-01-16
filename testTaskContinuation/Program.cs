using System;
using System.Threading;
using System.Threading.Tasks;

namespace testTaskContinuation
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() =>
            {
                return 1;
            }); 

            var awaiter = task.GetAwaiter();

            awaiter.OnCompleted(() =>
            {
                int result = awaiter.GetResult();
                System.Console.WriteLine(result);
            });

            Console.ReadKey();
        }
    }
}
