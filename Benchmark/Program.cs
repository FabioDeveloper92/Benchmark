using BenchmarkDotNet.Running;

namespace Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = BenchmarkRunner.Run<CreateStringBenchmark>();
        }
    }
}
