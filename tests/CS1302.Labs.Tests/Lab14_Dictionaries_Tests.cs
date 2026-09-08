using CS1302.Lab14.Dictionaries.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab14_Dictionaries_Tests
{
    [Fact]
    public void CountWords_Counts_Each_Word()
    {
        string[] words = { "a", "b", "a", "c", "a" };

        Dictionary<string, int> counts = WordFrequencyCounter.CountWords(words);

        Assert.Equal(3, counts["a"]);
        Assert.Equal(1, counts["b"]);
        Assert.Equal(1, counts["c"]);
    }

    [Fact]
    public void CountWords_Is_Case_Insensitive()
    {
        string[] words = { "Apple", "apple", "APPLE" };

        Dictionary<string, int> counts = WordFrequencyCounter.CountWords(words);

        Assert.Single(counts);
        Assert.Equal(3, counts["apple"]);
    }

    [Fact]
    public void CountWords_Returns_Empty_For_No_Words()
    {
        Dictionary<string, int> counts = WordFrequencyCounter.CountWords(Array.Empty<string>());

        Assert.Empty(counts);
    }
}
