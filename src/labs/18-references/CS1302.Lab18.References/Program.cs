using CS1302.Lab18.References.Models;

namespace CS1302.Lab18.References;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== References Practice ==");
        Console.WriteLine();

        int number = 5;
        Console.WriteLine($"Before TryIncrementValue: {number}");
        ReferenceDemo.TryIncrementValue(number);
        Console.WriteLine($"After TryIncrementValue: {number}");

        Console.WriteLine();
        Counter counter = new Counter(5);
        Console.WriteLine($"Before IncrementCounter: {counter.Value}");
        ReferenceDemo.IncrementCounter(counter);
        Console.WriteLine($"After IncrementCounter: {counter.Value}");

        Console.WriteLine();
        bool success = ReferenceDemo.TryParseCoordinate("3, 4", out int x, out int y);
        Console.WriteLine($"TryParseCoordinate(\"3, 4\") -> {success}, x={x}, y={y}");
    }
}
