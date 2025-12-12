using Day2;

var fileContent = await File.ReadAllTextAsync("input.txt");
var ranges = fileContent.Split(',');

var sumOfInvalidIdsPart1 = Part1.CalculateSumOfInvalidIds(ranges);
Console.WriteLine($"The sum of invalid ids for part 1 is: {sumOfInvalidIdsPart1}");

var sumOfInvalidIdsPart2 = Part2.CalculateSumOfInvalidIds(ranges);
Console.WriteLine($"The sum of invalid ids for part 2 is: {sumOfInvalidIdsPart2}");
