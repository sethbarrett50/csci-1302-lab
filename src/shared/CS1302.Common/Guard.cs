namespace CS1302.Common;

public static class Guard
{
    public static string NotNullOrWhiteSpace(string? value, string paramName)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("Value must not be null, empty, or whitespace.", paramName);
        }

        return value;
    }

    public static T NotNull<T>(T? value, string paramName)
        where T : class
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName);
        }

        return value;
    }

    public static int InRange(int value, int minInclusive, int maxInclusive, string paramName)
    {
        if (value < minInclusive || value > maxInclusive)
        {
            throw new ArgumentOutOfRangeException(
                paramName,
                value,
                $"Value must be in range [{minInclusive}, {maxInclusive}]."
            );
        }

        return value;
    }

    public static decimal Positive(decimal value, string paramName)
    {
        if (value <= 0m)
        {
            throw new ArgumentOutOfRangeException(
                paramName,
                value,
                "Value must be greater than 0."
            );
        }

        return value;
    }
}
