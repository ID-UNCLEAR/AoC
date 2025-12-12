namespace Day2;

internal static class Part2
{
    public static long CalculateSumOfInvalidIds(string[] ranges)
    {
        var sumOfInvalidIds = 0L;

        foreach (var range in ranges)
        {
            var idRange = range.Split('-');
            var firstId = long.Parse(idRange[0]);
            var lastId = long.Parse(idRange[1]);

            for (var currentId = firstId; lastId >= currentId; currentId++)
            {
                var idText = currentId.ToString();
                var totalLength = idText.Length;

                // Try all possible lengths for the base pattern
                for (var patternLength = 1; patternLength <= totalLength / 2; patternLength++)
                {
                    if (totalLength % patternLength != 0)
                        continue;

                    var basePattern = idText[..patternLength];
                    var repeatCount = totalLength / patternLength;

                    var isRepeatedPattern = true;

                    // Check each repeated segment
                    for (var segmentIndex = 1; segmentIndex < repeatCount; segmentIndex++)
                    {
                        var segment = idText.Substring(segmentIndex * patternLength, patternLength);
                        if (segment == basePattern)
                        {
                            continue;
                        }

                        isRepeatedPattern = false;
                        break;
                    }

                    if (!isRepeatedPattern)
                    {
                        continue;
                    }

                    sumOfInvalidIds += currentId;
                    break;
                }
            }
        }

        return sumOfInvalidIds;
    }
}
