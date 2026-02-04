using CS1302.Lab03.Arrays2D.Exercises;

namespace CS1302.Lab03.Arrays2D;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Arrays 2D Practice ==");

        int[,] grid =
        {
            { 3, 5, -2, 9 },
            { 1, 0, 4, 8 },
            { -7, 6, 2, 10 },
        };

        Console.WriteLine();
        Console.WriteLine("-- Row sums --");
        int[] rowSums = GridMath.RowSums(grid);
        PrintArray(rowSums);

        Console.WriteLine();
        Console.WriteLine("-- Column sums --");
        int[] colSums = GridMath.ColumnSums(grid);
        PrintArray(colSums);

        Console.WriteLine();
        Console.WriteLine("-- Max value + coordinates --");
        var max = GridMath.MaxValue(grid);
        Console.WriteLine($"Max: {max.Value} at (row={max.Row}, col={max.Col})");
    }

    private static void PrintArray(int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}
