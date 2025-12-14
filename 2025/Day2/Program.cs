using BenchmarkDotNet.Running;

using Day2;

var fileContent = await File.ReadAllTextAsync("input.txt");
var ranges = fileContent.Split(',');

var sumOfInvalidIdsPart1 = Part1.CalculateSumOfInvalidIds(ranges);
if (sumOfInvalidIdsPart1 != 23039913998)
{
    throw new InvalidOperationException("Answer is incorrect");
}

var sumOfInvalidIdsPart2 = Part2.CalculateSumOfInvalidIds(ranges);
if (sumOfInvalidIdsPart2 != 35950619148)
{
    throw new InvalidOperationException("Answer is incorrect");
}

BenchmarkRunner.Run<Part1Benchmark>();
BenchmarkRunner.Run<Part2Benchmark>();
