using BenchmarkDotNet.Running;

using Day3;

var banks = await File.ReadAllLinesAsync("input.txt");

var totalJoltageOuputPart1 = Part1.CalculateTotalJoltageOutput(banks);
if (totalJoltageOuputPart1 != 17430)
{
    throw new InvalidOperationException("Answer is incorrect");
}

var totalJoltageOuputPart2 = Part2.CalculateTotalJoltageOutput(banks);
if (totalJoltageOuputPart2 != 171975854269367)
{
    throw new InvalidOperationException("Answer is incorrect");
}

BenchmarkRunner.Run<Part1Benchmark>();
BenchmarkRunner.Run<Part2Benchmark>();
