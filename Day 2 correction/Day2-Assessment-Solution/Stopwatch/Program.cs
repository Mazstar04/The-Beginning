using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            stopwatch.Start();
            Console.WriteLine("Stopwatch started .......");
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            stopwatch.Stop();
            Console.WriteLine();
            Console.WriteLine($"Start time is: {stopwatch.GetStartTime()}");
            Console.WriteLine($"Stop time is: {stopwatch.GetEndTime()}");
            Console.WriteLine($"Number of milliseonds elapsed is: {stopwatch.GetElapsed()}");
            Console.WriteLine($"Elapsed time in seconds is: {Math.Round((stopwatch.GetElapsed() * 0.001))}s");
        }
    }
}
