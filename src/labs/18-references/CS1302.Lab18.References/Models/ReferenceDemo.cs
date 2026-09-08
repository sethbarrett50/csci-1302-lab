namespace CS1302.Lab18.References.Models;

public static class ReferenceDemo
{
    public static void TryIncrementValue(int value)
    {
        value++;
    }

    public static void IncrementCounter(Counter counter)
    {
        counter.Value++;
    }

    public static bool TryParseCoordinate(string text, out int x, out int y)
    {
        x = 0;
        y = 0;

        string[] parts = text.Split(',');
        if (parts.Length != 2)
        {
            return false;
        }

        return int.TryParse(parts[0].Trim(), out x) && int.TryParse(parts[1].Trim(), out y);
    }
}
