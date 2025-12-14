namespace Day2;

internal static class Part1
{
    public static long CalculateSumOfInvalidIds(ReadOnlySpan<string> ranges)
    {
        var sumOfInvalidIds = 0L;

        foreach (var range in ranges)
        {
            var dashIndex = range.IndexOf('-');
            var firstId = long.Parse(range.AsSpan(0, dashIndex));
            var lastId = long.Parse(range.AsSpan(dashIndex + 1));

            for (var currentId = firstId; currentId <= lastId; currentId++)
            {
                if (HasMatchingHalves(currentId))
                {
                    sumOfInvalidIds += currentId;
                }
            }
        }

        return sumOfInvalidIds;
    }

    private static bool HasMatchingHalves(long number)
    {
        Span<char> buffer = stackalloc char[20];
        number.TryFormat(buffer, out var charsWritten);

        if (charsWritten % 2 != 0)
        {
            return false;
        }

        var halfSize = charsWritten / 2;
        var span = buffer[..charsWritten];

        return span[..halfSize].SequenceEqual(span[halfSize..]);
    }
}
