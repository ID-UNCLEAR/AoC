namespace Day1;

internal static class Part2
{
    public static short CalculateAmountOfZeroPositions(IEnumerable<string> rotationInstructions)
    {
        var dialPosition = 50;
        short numberOfZeros = 0;

        foreach (var rotationInstruction in rotationInstructions)
        {
            var direction = rotationInstruction[0];
            var distance = short.Parse(rotationInstruction[1..]);

            for (var i = 1; i <= distance; i++)
            {
                if (direction == 'L')
                {
                    dialPosition = (dialPosition - 1 + 100) % 100;
                }
                else
                {
                    dialPosition = (dialPosition + 1) % 100;
                }

                if (dialPosition == 0)
                {
                    numberOfZeros++;
                }
            }
        }

        return numberOfZeros;
    }
}
