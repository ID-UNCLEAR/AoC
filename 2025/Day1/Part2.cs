namespace Day1;

internal static class Part2
{
    public static short CalculateAmountOfZeroPositions(ReadOnlySpan<string> rotationInstructions)
    {
        var dialPosition = 50;
        short numberOfZeros = 0;

        foreach (var rotationInstruction in rotationInstructions)
        {
            var direction = rotationInstruction[0];
            var distance = 0;

            for (var i = 1; i < rotationInstruction.Length; i++)
            {
                distance = (distance * 10) + (rotationInstruction[i] - '0');
            }

            for (var i = 1; i <= distance; i++)
            {
                dialPosition = CalculateNewPosition(dialPosition, direction);

                if (dialPosition == 0)
                {
                    numberOfZeros++;
                }
            }
        }

        return numberOfZeros;
    }

    private static int CalculateNewPosition(int currentPosition, char direction)
    {
        if (direction == 'L')
        {
            return (currentPosition - 1 + 100) % 100;
        }

        return (currentPosition + 1) % 100;
    }
}
