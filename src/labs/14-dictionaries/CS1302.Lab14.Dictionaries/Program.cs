using CS1302.Lab14.Dictionaries.Models;

namespace CS1302.Lab14.Dictionaries;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Dictionaries Practice ==");
        Console.WriteLine();

        string[] words = { "apple", "Banana", "apple", "cherry", "banana", "Apple" };
        Dictionary<string, int> counts = WordFrequencyCounter.CountWords(words);

        foreach (KeyValuePair<string, int> pair in counts)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
