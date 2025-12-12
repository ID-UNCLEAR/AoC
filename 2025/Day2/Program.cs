var fileContent = await File.ReadAllTextAsync("input.txt");
var ranges = fileContent.Split(',');
var sumOfInvalidIds = 0L;

foreach (var range in ranges)
{
    var idRange = range.Split('-');
    var firstId = long.Parse(idRange[0]);
    var lastId = long.Parse(idRange[1]);

    for (var currentId = firstId; lastId >= currentId; currentId++)
    {
        var currentIdString = currentId.ToString();
        var halfSize = currentIdString.Length / 2;

        var firstHalf = currentIdString[..halfSize];
        var secondHalf = currentIdString[halfSize..];

        if (firstHalf == secondHalf)
        {
            sumOfInvalidIds += currentId;
        }
    }
}

Console.WriteLine($"The sum of invalid ids is: {sumOfInvalidIds}");
