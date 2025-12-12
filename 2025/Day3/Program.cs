using Day3;

var banks = File.ReadLines("input.txt");

var totalJoltageOuputPart1 = Part1.CalculateTotalJoltageOutput(banks);
Console.WriteLine($"The sum of invalid ids for part 1 is: {totalJoltageOuputPart1}");

var totalJoltageOuputPart2 = Part2.CalculateTotalJoltageOutput(banks);
Console.WriteLine($"The sum of invalid ids for part 2 is: {totalJoltageOuputPart2}");
