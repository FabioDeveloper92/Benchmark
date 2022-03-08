using BenchmarkDotNet.Attributes;

namespace Benchmark
{
    [MemoryDiagnoser]
    public class CreateStringBenchmark
    {
        // the objs in common of every method, it's better declare global,
        // in this way we use the same instance and we don't have slowdowns due to creation
        private const int NUMITEMS = 5000;
        private static readonly CreateString CreateString = new(NUMITEMS);

        [Benchmark(Baseline = true)]
        public void GenerateWithStringBuilder()
        {
            CreateString.GenerateWithStringBuilder();
        }  
        
        [Benchmark(Baseline = false)]
        public void GenerateWithList()
        {
            CreateString.GenerateWithList();
        }
    }
}
