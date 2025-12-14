namespace Day1;

internal static class Part1
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

            dialPosition = CalculateNewPosition(dialPosition, direction, distance);

            if (dialPosition == 0)
            {
                numberOfZeros++;
            }
        }

        return numberOfZeros;
    }

    private static int CalculateNewPosition(int currentPosition, char direction, int distance)
    {
        if (direction == 'L')
        {
            distance = -distance;
        }

        currentPosition = (currentPosition + distance) % 100;

        if (currentPosition < 0)
        {
            currentPosition += 100;
        }

        return currentPosition;
    }
}
