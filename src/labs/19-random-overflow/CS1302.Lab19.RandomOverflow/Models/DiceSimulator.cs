namespace CS1302.Lab19.RandomOverflow.Models;

public class DiceSimulator
{
    private readonly Random _random;

    public DiceSimulator(int seed)
    {
        _random = new Random(seed);
    }

    public int RollDie()
    {
        return _random.Next(1, 7);
    }
}
