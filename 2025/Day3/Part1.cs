namespace Day3;

internal static class Part1
{
    public static int CalculateTotalJoltageOutput(ReadOnlySpan<string> joltageBanks)
    {
        var totalJoltageOutput = 0;
        Span<int> firstOccurrence = stackalloc int[10];

        foreach (var joltageBank in joltageBanks)
        {
            var joltageOutputOfBank = 0;
            var joltageRatingsLength = joltageBank.Length;

            firstOccurrence.Fill(-1);

            for (var i = 0; i < joltageRatingsLength; i++)
            {
                var rating = joltageBank[i] - '0';

                if (firstOccurrence[rating] == -1)
                {
                    firstOccurrence[rating] = i;
                }
            }

            for (var index = 1; index <= 9; index++)
            {
                if (firstOccurrence[index] == -1)
                {
                    continue;
                }

                var remainingStartIndex = firstOccurrence[index] + 1;
                if (remainingStartIndex >= joltageRatingsLength)
                {
                    continue;
                }

                var secondHighestJoltageRating = 0;
                for (var i = remainingStartIndex; i < joltageRatingsLength; i++)
                {
                    var rating = joltageBank[i] - '0';
                    if (rating > secondHighestJoltageRating)
                    {
                        secondHighestJoltageRating = rating;
                    }
                }

                if (secondHighestJoltageRating == 0)
                {
                    continue;
                }

                var projectedOutputOfBank = (index * 10) + secondHighestJoltageRating;

                if (projectedOutputOfBank > joltageOutputOfBank)
                {
                    joltageOutputOfBank = projectedOutputOfBank;
                }
            }

            totalJoltageOutput += joltageOutputOfBank;
        }

        return totalJoltageOutput;
    }
}
