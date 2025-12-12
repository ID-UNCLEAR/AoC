using System.Text;

namespace Day3;

internal static class Part2
{
    public static long CalculateTotalJoltageOutput(IEnumerable<string> banks)
    {
        var totalJoltageOutput = 0L;

        foreach (var bank in banks)
        {
            long joltageOutputOfBank;

            var joltageRatings = bank.Select(n => int.Parse(new ReadOnlySpan<char>(in n))).ToArray();

            var joltageRatingDictionary = new Dictionary<int, long>();
            for (var index = 0; index < joltageRatings.Length; index++)
            {
                var joltageRating = joltageRatings[index];
                joltageRatingDictionary.Add(index, joltageRating);
            }

            var highestJoltageRatings = joltageRatingDictionary
                .OrderByDescending(jr => jr.Value)
                .Take(12)
                .ToArray();

            var sortedHighestJoltageRatings = highestJoltageRatings
                .OrderBy(jr => jr.Key)
                .Select(jr => jr.Value)
                .ToArray();

            var stringBuilder = new StringBuilder();

            foreach (var joltageRating in sortedHighestJoltageRatings)
            {
                stringBuilder.Append(joltageRating);
            }

            joltageOutputOfBank = long.Parse(stringBuilder.ToString());

            totalJoltageOutput += joltageOutputOfBank;
        }

        return totalJoltageOutput;
    }
}
