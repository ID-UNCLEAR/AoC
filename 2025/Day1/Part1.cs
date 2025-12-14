namespace Day1;

internal static class Part1
{
    public static short CalculateAmountOfZeroPositions(IEnumerable<string> rotationInstructions)
    {
        var dialPosition = 50;
        short numberOfZeros = 0;

        foreach (var rotationInstruction in rotationInstructions)
        {
            var direction = rotationInstruction[0];
            var distance = short.Parse(rotationInstruction[1..]);

            if (direction == 'L')
            {
                dialPosition = (dialPosition - distance) % 100;

                if (dialPosition < 0)
                {
                    dialPosition += 100;
                }
            }
            else
            {
                dialPosition = (dialPosition + distance) % 100;
            }

            if (dialPosition == 0)
            {
                numberOfZeros++;
            }
        }

        return numberOfZeros;
    }
}
