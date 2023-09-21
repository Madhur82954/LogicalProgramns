using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class StopWatch
    {
        public void CheckTime()
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.Write(i);
            }

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
