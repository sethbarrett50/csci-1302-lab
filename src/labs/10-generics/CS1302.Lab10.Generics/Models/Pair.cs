namespace CS1302.Lab10.Generics.Models;

public class Pair<TFirst, TSecond>
{
    public TFirst First { get; }
    public TSecond Second { get; }

    public Pair(TFirst first, TSecond second)
    {
        First = first;
        Second = second;
    }

    public string Describe()
    {
        return $"({First}, {Second})";
    }
}
