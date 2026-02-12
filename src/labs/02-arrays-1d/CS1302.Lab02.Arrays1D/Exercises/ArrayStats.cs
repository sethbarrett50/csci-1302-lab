namespace CS1302.Lab02.Arrays1D.Exercises;

public static class ArrayStats
{
    public static double[] Compute(int[] values)
    {
        if (values == null)
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

        for (int i = 0; i < values.Length; i++)
        {
            int v = values[i];

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

        return new double[] { min, max, avg, evenCount };
    }
}
