using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Day3;

[SimpleJob(RuntimeMoniker.Net10_0)]
[MemoryDiagnoser]
public class Part2Benchmark
{
    private string[] _banks = [];

    [GlobalSetup]
    public async Task SetupAsync()
    {
        _banks = await File.ReadAllLinesAsync("input.txt");
    }

    [Benchmark]
    public long Day3Part2()
    {
        return Part2.CalculateTotalJoltageOutput(_banks);
    }
}
