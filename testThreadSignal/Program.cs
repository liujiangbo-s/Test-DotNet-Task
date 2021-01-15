using System;
using System.Threading;

namespace testThreadSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            var signal = new ManualResetEvent(false);

            new Thread(() =>
            {
                System.Console.WriteLine("1. Waiting for signal...");
                signal.WaitOne();
                System.Console.WriteLine("1. Got signal");
            }).Start();

            Thread.Sleep(2000);

            signal.Set();

            signal.Reset();

            new Thread(() =>
            {
                System.Console.WriteLine("2. Waiting for signal...");
                signal.WaitOne();
                signal.Dispose();
                System.Console.WriteLine("2. Got signal");
            }).Start();
        }
        // 结果
        // 1. Waiting for signal...
        // 1. Got signal
        // 2. Waiting for signal...
    }
}
