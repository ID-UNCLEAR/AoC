using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Day2;

[SimpleJob(RuntimeMoniker.Net10_0)]
[MemoryDiagnoser]
public class Benchmark
{
    private string[] _ranges = [];

    [GlobalSetup]
    public async Task SetupAsync()
    {
        var fileContent = await File.ReadAllTextAsync("input.txt");
        _ranges = fileContent.Split(',');
    }

    [Benchmark]
    public long Day2Part1()
    {
        return Part1.CalculateSumOfInvalidIds(_ranges);
    }

    [Benchmark]
    public long Day2Part2()
    {
        return Part2.CalculateSumOfInvalidIds(_ranges);
    }
}
