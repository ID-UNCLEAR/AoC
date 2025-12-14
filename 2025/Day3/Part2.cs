namespace Day3;

internal static class Part2
{
    private const byte MaximumJoltageCountPerBank = 12;

    public static long CalculateTotalJoltageOutput(ReadOnlySpan<string> joltageBanks)
    {
        var totalJoltageOutput = 0L;
        Span<byte> optimalJoltageRatingSequence = stackalloc byte[MaximumJoltageCountPerBank];

        foreach (var joltageBank in joltageBanks)
        {
            var joltageRatingsLength = joltageBank.Length;
            var sequenceCount = 0;

            for (var index = 0; index < joltageRatingsLength; index++)
            {
                var currentJoltageRating = (byte)(joltageBank[index] - '0');

                while (
                    sequenceCount > 0 &&
                    currentJoltageRating > optimalJoltageRatingSequence[sequenceCount - 1] &&
                    sequenceCount - 1 + (joltageRatingsLength - index) >= MaximumJoltageCountPerBank)
                {
                    sequenceCount--;
                }

                if (sequenceCount < MaximumJoltageCountPerBank)
                {
                    optimalJoltageRatingSequence[sequenceCount++] = currentJoltageRating;
                }
            }

            var joltageOutput = 0L;
            for (var i = 0; i < sequenceCount; i++)
            {
                joltageOutput = (joltageOutput * 10) + optimalJoltageRatingSequence[i];
            }

            totalJoltageOutput += joltageOutput;
        }

        return totalJoltageOutput;
    }
}
