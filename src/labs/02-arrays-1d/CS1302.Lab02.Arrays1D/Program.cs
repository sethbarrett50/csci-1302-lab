using CS1302.Lab02.Arrays1D.Exercises;

namespace CS1302.Lab02.Arrays1D;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Arrays 1D Practice ==");

        int[] numbers = { 7, -2, 14, 0, 9, 9, 4 };
        string[] words = { "cat", "dog", "cat", "bird", "CAT" };

        Console.WriteLine();
        Console.WriteLine("-- Stats --");
        double[] stats = ArrayStats.Compute(numbers);
        Console.WriteLine($"Min: {stats[0]}");
        Console.WriteLine($"Max: {stats[1]}");
        Console.WriteLine($"Avg: {stats[2]:F2}");
        Console.WriteLine($"EvenCount: {stats[3]}");

        Console.WriteLine();
        Console.WriteLine("-- Search + Replace --");
        int idx = ArraySearch.IndexOf(words, "cat");
        Console.WriteLine($"IndexOf('cat'): {idx}");

        int replaced = ArraySearch.ReplaceAll(words, "cat", "fox", ignoreCase: true);
        Console.WriteLine($"Replaced: {replaced}");
        Console.WriteLine("Updated array:");
        foreach (string w in words)
        {
            Console.WriteLine($"- {w}");
        }
    }
}
