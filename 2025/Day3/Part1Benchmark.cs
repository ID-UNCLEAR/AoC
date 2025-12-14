using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Day3;

[SimpleJob(RuntimeMoniker.Net10_0)]
[MemoryDiagnoser]
public class Part1Benchmark
{
    private string[] _banks = [];

    [GlobalSetup]
    public async Task SetupAsync()
    {
        _banks = await File.ReadAllLinesAsync("input.txt");
    }

    [Benchmark]
    public int Day3Part1()
    {
        return Part1.CalculateTotalJoltageOutput(_banks);
    }
}
