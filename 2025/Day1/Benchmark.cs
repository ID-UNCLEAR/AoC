using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Day1;

[SimpleJob(RuntimeMoniker.Net10_0)]
[MemoryDiagnoser]
public class Benchmark
{
    private string[] _rotationInstructions = [];

    [GlobalSetup]
    public async Task SetupAsync()
    {
        _rotationInstructions = await File.ReadAllLinesAsync("input.txt");
    }

    [Benchmark]
    public short Day1Part1()
    {
        return Part1.CalculateAmountOfZeroPositions(_rotationInstructions);
    }

    [Benchmark]
    public short Day1Part2()
    {
        return Part2.CalculateAmountOfZeroPositions(_rotationInstructions);
    }
}
