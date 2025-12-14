using BenchmarkDotNet.Running;
using Day1;

var rotationInstructions = await File.ReadAllLinesAsync("input.txt");
var numberOfZerosPart1 = Part1.CalculateAmountOfZeroPositions(rotationInstructions);
if (numberOfZerosPart1 != 1071)
{
    throw new InvalidOperationException("Answer is incorrect");
}

var numberOfZerosPart2 = Part2.CalculateAmountOfZeroPositions(rotationInstructions);
if (numberOfZerosPart2 != 6700)
{
    throw new InvalidOperationException("Answer is incorrect");
}

BenchmarkRunner.Run<Part1Benchmark>();
BenchmarkRunner.Run<Part2Benchmark>();
