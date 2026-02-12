using CS1302.Lab02.Arrays1D.Exercises;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab02_Arrays1D_Tests
{
    [Fact]
    public void Stats_Computes_MinMaxAvgEvenCount()
    {
        int[] values = { 2, 5, -1, 4 };

        double[] result = ArrayStats.Compute(values);

        Assert.Equal(-1, result[0]);
        Assert.Equal(5, result[1]);
        Assert.Equal(2.5, result[2], 5);
        Assert.Equal(2, result[3]);
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
