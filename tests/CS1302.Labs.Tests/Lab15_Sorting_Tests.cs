using CS1302.Lab15.Sorting.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab15_Sorting_Tests
{
    public static IEnumerable<object[]> SampleArrays()
    {
        yield return new object[] { Array.Empty<int>() };
        yield return new object[] { new[] { 1 } };
        yield return new object[] { new[] { 1, 2, 3, 4, 5 } };
        yield return new object[] { new[] { 5, 4, 3, 2, 1 } };
        yield return new object[] { new[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 } };
        yield return new object[] { new[] { 7, 7, 7, 7 } };
    }

    [Theory]
    [MemberData(nameof(SampleArrays))]
    public void BubbleSort_Matches_ArraySort(int[] values)
    {
        int[] expected = (int[])values.Clone();
        Array.Sort(expected);

        int[] actual = (int[])values.Clone();
        Sorter.BubbleSort(actual);

        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(SampleArrays))]
    public void SelectionSort_Matches_ArraySort(int[] values)
    {
        int[] expected = (int[])values.Clone();
        Array.Sort(expected);

        int[] actual = (int[])values.Clone();
        Sorter.SelectionSort(actual);

        Assert.Equal(expected, actual);
    }
}
