using System;
using System.Threading;
using System.Threading.Tasks;

namespace testTsk
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(5000);
                System.Console.WriteLine("Hello World");
            }, TaskCreationOptions.LongRunning);

            task.Wait(); 
        }
    }
}
