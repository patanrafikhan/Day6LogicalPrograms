using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var time = StopwatchHelper.MeasureRunTime(() =>
            {
                for (var i = 0; i < 2; i++)
                {
                    using (var task = Task.Delay(1000))
                    {
                        task.Wait();
                    }
                }
            });

            Console.WriteLine("Time elapsed: " + time);
        }

        static class StopwatchHelper
        {
            public static TimeSpan MeasureRunTime(Action codeToRun)
            {
                var watch = Stopwatch.StartNew();

                codeToRun();

                watch.Stop();

                return watch.Elapsed;
            }
        }
    }
}
