namespace CS1302.Lab14.Dictionaries.Models;

public static class WordFrequencyCounter
{
    public static Dictionary<string, int> CountWords(IEnumerable<string> words)
    {
        Dictionary<string, int> counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        foreach (string word in words)
        {
            if (counts.TryGetValue(word, out int count))
            {
                counts[word] = count + 1;
            }
            else
            {
                counts[word] = 1;
            }
        }

        return counts;
    }
}
