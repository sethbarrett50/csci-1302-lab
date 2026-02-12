namespace CS1302.Lab02.Arrays1D.Exercises;

public static class ArraySearch
{
    public static int IndexOf(string[] values, string target)
    {
        if (values is null)
        {
            throw new ArgumentNullException(nameof(values));
        }

        if (target is null)
        {
            throw new ArgumentNullException(nameof(target));
        }

        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] == target)
            {
                return i;
            }
        }

        return -1;
    }

    public static int ReplaceAll(string[] values, string from, string to, bool ignoreCase)
    {
        if (values is null)
        {
            throw new ArgumentNullException(nameof(values));
        }

        if (from is null)
        {
            throw new ArgumentNullException(nameof(from));
        }

        if (to is null)
        {
            throw new ArgumentNullException(nameof(to));
        }

        StringComparison comparison = ignoreCase
            ? StringComparison.OrdinalIgnoreCase
            : StringComparison.Ordinal;

        int replaced = 0;
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] is null)
            {
                continue;
            }

            if (string.Equals(values[i], from, comparison))
            {
                values[i] = to;
                replaced++;
            }
        }

        return replaced;
    }
}
