using CS1302.Lab19.RandomOverflow.Models;

namespace CS1302.Lab19.RandomOverflow;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Random & Overflow Practice ==");
        Console.WriteLine();

        DiceSimulator dice = new DiceSimulator(42);
        Console.WriteLine("Rolling a seeded die 5 times:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Roll {i + 1}: {dice.RollDie()}");
        }

        Console.WriteLine();
        Console.WriteLine($"int.MaxValue = {int.MaxValue}");
        int wrapped = OverflowDemo.UncheckedAdd(int.MaxValue, 1);
        Console.WriteLine($"Unchecked int.MaxValue + 1 = {wrapped}");

        Console.WriteLine();
        Console.WriteLine("Checked int.MaxValue + 1 throws OverflowException:");
        try
        {
            OverflowDemo.CheckedAdd(int.MaxValue, 1);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Caught: {ex.Message}");
        }
    }
}
