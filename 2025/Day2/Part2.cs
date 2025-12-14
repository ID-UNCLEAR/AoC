namespace Day2;

internal static class Part2
{
    public static long CalculateSumOfInvalidIds(ReadOnlySpan<string> ranges)
    {
        var sumOfInvalidIds = 0L;
        Span<char> buffer = stackalloc char[21];

        foreach (var range in ranges)
        {
            var rangeSpan = range.AsSpan();
            var separatorIndex = rangeSpan.IndexOf('-');
            var firstId = long.Parse(rangeSpan[..separatorIndex]);
            var lastId = long.Parse(rangeSpan[(separatorIndex + 1)..]);

            for (var currentId = firstId; currentId <= lastId; currentId++)
            {
                if (currentId.TryFormat(buffer, out var charsWritten) && HasRepeatingPattern(buffer[..charsWritten]))
                {
                    sumOfInvalidIds += currentId;
                }
            }
        }

        return sumOfInvalidIds;
    }

    private static bool HasRepeatingPattern(ReadOnlySpan<char> idText)
    {
        var totalLength = idText.Length;

        // Try all possible lengths for the base pattern
        for (var patternLength = 1; patternLength <= totalLength / 2; patternLength++)
        {
            if (totalLength % patternLength != 0)
            {
                continue;
            }

            var basePattern = idText[..patternLength];
            var repeatCount = totalLength / patternLength;

            var isRepeatedPattern = true;

            // Check each repeated segment
            for (var segmentIndex = 1; segmentIndex < repeatCount; segmentIndex++)
            {
                var segment = idText.Slice(segmentIndex * patternLength, patternLength);
                if (segment.SequenceEqual(basePattern))
                {
                    continue;
                }

                isRepeatedPattern = false;
                break;
            }

            if (isRepeatedPattern)
            {
                return true;
            }
        }

        return false;
    }
}
