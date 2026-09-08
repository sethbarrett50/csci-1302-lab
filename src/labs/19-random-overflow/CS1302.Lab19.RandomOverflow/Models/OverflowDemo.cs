namespace CS1302.Lab19.RandomOverflow.Models;

public static class OverflowDemo
{
    public static int UncheckedAdd(int a, int b)
    {
        unchecked
        {
            return a + b;
        }
    }

    public static int CheckedAdd(int a, int b)
    {
        checked
        {
            return a + b;
        }
    }
}
