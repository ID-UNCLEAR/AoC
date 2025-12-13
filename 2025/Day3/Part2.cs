using System.Text;

namespace Day3;

internal static class Part2
{
    private const int MaximumJoltageCountPerBank = 12;

    public static long CalculateTotalJoltageOutput(IEnumerable<string> joltageBanks)
    {
        var totalJoltageOutput = 0L;

        foreach (var joltageBank in joltageBanks)
        {
            var joltageRatings = joltageBank.Select(c => c - '0').ToArray();
            var optimalJoltageRatingSequence = new List<int>(MaximumJoltageCountPerBank);

            for (var index = 0; index < joltageRatings.Length; index++)
            {
                var currentJoltageRating = joltageRatings[index];

                while (
                    optimalJoltageRatingSequence.Count > 0 &&
                    currentJoltageRating > optimalJoltageRatingSequence[^1] &&
                    optimalJoltageRatingSequence.Count - 1 + (joltageRatings.Length - index) >= MaximumJoltageCountPerBank)
                {
                    optimalJoltageRatingSequence.RemoveAt(optimalJoltageRatingSequence.Count - 1);
                }

                if (optimalJoltageRatingSequence.Count < MaximumJoltageCountPerBank)
                {
                    optimalJoltageRatingSequence.Add(currentJoltageRating);
                }
            }

            var stringBuilder = new StringBuilder(MaximumJoltageCountPerBank);
            foreach (var joltageRating in optimalJoltageRatingSequence)
            {
                stringBuilder.Append(joltageRating);
            }

            totalJoltageOutput += long.Parse(stringBuilder.ToString());
        }

        return totalJoltageOutput;
    }
}
