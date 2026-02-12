namespace CS1302.Lab03.Arrays2D.Exercises;

public static class GridMath
{
    public static int[] RowSums(int[,] grid)
    {
        if (grid == null)
        {
            throw new ArgumentNullException(nameof(grid));
        }

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        int[] sums = new int[rows];

        for (int r = 0; r < rows; r++)
        {
            int sum = 0;
            for (int c = 0; c < cols; c++)
            {
                sum += grid[r, c];
            }
            sums[r] = sum;
        }

        return sums;
    }

    public static int[] ColumnSums(int[,] grid)
    {
        if (grid == null)
        {
            throw new ArgumentNullException(nameof(grid));
        }

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        int[] sums = new int[cols];

        for (int c = 0; c < cols; c++)
        {
            int sum = 0;
            for (int r = 0; r < rows; r++)
            {
                sum += grid[r, c];
            }
            sums[c] = sum;
        }

        return sums;
    }

    public static int[] MaxValue(int[,] grid)
    {
        if (grid == null)
        {
            throw new ArgumentNullException(nameof(grid));
        }

        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);

        if (rows == 0 || cols == 0)
        {
            throw new ArgumentException(
                "Grid must have at least 1 row and 1 column.",
                nameof(grid)
            );
        }

        int bestVal = grid[0, 0];
        int bestR = 0;
        int bestC = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int v = grid[r, c];
                if (v > bestVal)
                {
                    bestVal = v;
                    bestR = r;
                    bestC = c;
                }
            }
        }

        return new int[] { bestVal, bestR, bestC };
    }
}
