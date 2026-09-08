namespace CS1302.Lab20.Recursion.Models;

public static class RecursiveMath
{
    public static int Sum(int[] values)
    {
        return SumFrom(values, 0);
    }

    private static int SumFrom(int[] values, int index)
    {
        if (index >= values.Length)
        {
            return 0;
        }

        return values[index] + SumFrom(values, index + 1);
    }

    public static string Reverse(string text)
    {
        if (text.Length <= 1)
        {
            return text;
        }

        return Reverse(text.Substring(1)) + text[0];
    }

    public static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}
