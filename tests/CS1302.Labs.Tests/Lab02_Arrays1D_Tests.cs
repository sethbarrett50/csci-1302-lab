using CS1302.Lab02.Arrays1D.Exercises;
using Xunit;

namespace CS1302.Labs.Tests;

public sealed class Lab02_Arrays1D_Tests
{
    [Fact]
    public void Stats_Computes_MinMaxAvgEvenCount()
    {
        int[] values = { 2, 5, -1, 4 };

        var result = ArrayStats.Compute(values);

        Assert.Equal(-1, result.Min);
        Assert.Equal(5, result.Max);
        Assert.Equal(2.5, result.Average, 5);
        Assert.Equal(2, result.EvenCount);
    }

    [Fact]
    public void ReplaceAll_CanIgnoreCase()
    {
        string[] words = { "cat", "CAT", "dog" };

        int replaced = ArraySearch.ReplaceAll(words, "cat", "fox", ignoreCase: true);

        Assert.Equal(2, replaced);
        Assert.Equal(new[] { "fox", "fox", "dog" }, words);
    }
}
