using System.Text;

namespace Day3;

internal static class Part2
{
    public static long CalculateTotalJoltageOutput(IEnumerable<string> banks)
    {
        var totalJoltageOutput = 0L;

        foreach (var bank in banks)
        {
            var joltageRatings = bank.Select(n => int.Parse(new ReadOnlySpan<char>(in n))).ToArray();

            var temp = new Stack<int>(capacity: 12);

            for (var index = 0; index < joltageRatings.Length; index++)
            {
                var rating = joltageRatings[index];

                var remainingSpots = 12 - temp.Count;
                var remainingJoltageRatingCount = joltageRatings.Length - index;

                if (temp.Count != 0 && remainingJoltageRatingCount > remainingSpots)
                {
                    var firstJoltageRating = temp.Peek();
                    if (rating > firstJoltageRating)
                    {
                        temp.Pop();
                    }
                }

                if (temp.Count < 12)
                {
                    temp.Push(rating);
                }
            }

            var result = temp.Reverse().ToArray();

            var stringBuilder = new StringBuilder();
            foreach (var val in result)
            {
                stringBuilder.Append(val);
            }

            var joltageOutputOfBank = long.Parse(stringBuilder.ToString());
            totalJoltageOutput += joltageOutputOfBank;
        }

        return totalJoltageOutput;
    }
}
