using CS1302.Lab03.Arrays2D.Exercises;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab03_Arrays2D_Tests
{
    [Fact]
    public void RowSums_And_ColumnSums_Work()
    {
        int[,] grid =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
        };

        Assert.Equal(new[] { 6, 15 }, GridMath.RowSums(grid));
        Assert.Equal(new[] { 5, 7, 9 }, GridMath.ColumnSums(grid));
    }

    [Fact]
    public void MaxValue_FindsBestCell()
    {
        int[,] grid =
        {
            { 1, 2 },
            { 9, 3 },
        };

        int[] max = GridMath.MaxValue(grid);
        Assert.Equal(9, max[0]);
        Assert.Equal(1, max[1]);
        Assert.Equal(0, max[2]);
    }
}
