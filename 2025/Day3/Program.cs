var totalJoltageOutput = 0;

foreach (var bank in File.ReadLines("input.txt"))
{
    var joltageOutputOfBank = 0;

    var joltageRatings = bank.Select(n => int.Parse(new ReadOnlySpan<char>(in n))).ToArray();

    for (var index = 1; index <= 9; index++)
    {
        if (!joltageRatings.Contains(index))
        {
            continue;
        }

        var highestJoltageRatingIndex = joltageRatings.IndexOf(index) + 1; // To skip the highest number being included twice
        var remainingJoltageRatings = joltageRatings[highestJoltageRatingIndex..];
        if (remainingJoltageRatings.Length == 0)
        {
            continue;
        }

        var secondHighestJoltageRating = remainingJoltageRatings.Max();

        var projectedOutputOfBank = int.Parse($"{index}{secondHighestJoltageRating}");

        if (projectedOutputOfBank > joltageOutputOfBank)
        {
            joltageOutputOfBank = projectedOutputOfBank;
        }
    }

    totalJoltageOutput += joltageOutputOfBank;
}

Console.WriteLine($"Total output joltage is {totalJoltageOutput}");
