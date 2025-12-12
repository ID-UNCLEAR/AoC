var dialIndex = 50;
var numberOfZeros = 0;

foreach (var line in File.ReadLines("input.txt"))
{
    var direction = line[0];
    var distance = int.Parse(line[1..]);

    if (direction == 'L')
    {
        dialIndex = (dialIndex - distance) % 100;

        if (dialIndex < 0)
        {
            dialIndex += 100;
        }
    }
    else
    {
        dialIndex = (dialIndex + distance) % 100;
    }

    if (dialIndex == 0)
    {
        numberOfZeros++;
    }
}

Console.WriteLine(numberOfZeros);
