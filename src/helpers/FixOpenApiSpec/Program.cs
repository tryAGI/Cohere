var path = args[0];
var lines = await File.ReadAllLinesAsync(path);
var output = new List<string>(lines.Length);

var insideTruncationStrategy = false;
var skippingDiscriminator = false;

foreach (var line in lines)
{
    if (line == "    TruncationStrategy:")
    {
        insideTruncationStrategy = true;
        output.Add(line);
        continue;
    }

    if (insideTruncationStrategy && line.StartsWith("    ") && !line.StartsWith("      "))
    {
        insideTruncationStrategy = false;
    }

    if (insideTruncationStrategy && line == "      discriminator:")
    {
        // The upstream spec maps this discriminator to schemas that are not present.
        skippingDiscriminator = true;
        continue;
    }

    if (skippingDiscriminator)
    {
        if (line.Length == 0 || line.StartsWith("        "))
        {
            continue;
        }

        skippingDiscriminator = false;
    }

    output.Add(line);
}

await File.WriteAllLinesAsync(path, output);
