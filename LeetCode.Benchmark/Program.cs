using System;
using BenchmarkDotNet.Running;

namespace LeetCode.Benchmark
{
    class Program
    {


        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<OpenTheLockBenchmark>();

            var benchmark = new OpenTheLockBenchmark();
            for(int i = 0; i < 10; ++i)
            {
                benchmark.OpenTheLock();
            }
        }
    }
}
