namespace CS1302.Lab02.Arrays1D.Exercises;

public readonly record struct StatsResult(int Min, int Max, double Average, int EvenCount);

public static class ArrayStats
{
    public static StatsResult Compute(int[] values)
    {
        if (values is null)
        {
            throw new ArgumentNullException(nameof(values));
        }

        if (values.Length == 0)
        {
            throw new ArgumentException("Array must not be empty.", nameof(values));
        }

        int min = values[0];
        int max = values[0];
        long sum = 0;
        int evenCount = 0;

        foreach (int v in values)
        {
            if (v < min)
                min = v;
            if (v > max)
                max = v;

            sum += v;

            if (v % 2 == 0)
            {
                evenCount++;
            }
        }

        double avg = (double)sum / values.Length;
        return new StatsResult(min, max, avg, evenCount);
    }
}
