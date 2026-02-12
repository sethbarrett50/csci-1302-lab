using CS1302.Lab04.PropertiesExceptions.Models;

namespace CS1302.Lab04.PropertiesExceptions;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Properties + Exceptions Practice ==");

        Console.WriteLine();
        Console.WriteLine("-- BankAccount --");
        BankAccount acct = new BankAccount("Seth", 100m);
        Console.WriteLine(acct);

        acct.Deposit(25m);
        Console.WriteLine("After deposit: " + acct);

        acct.Withdraw(60m);
        Console.WriteLine("After withdraw: " + acct);

        Console.WriteLine();
        Console.WriteLine("Trying an invalid withdraw...");
        try
        {
            acct.Withdraw(999m);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught: {ex.GetType().Name}: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("-- Temperature --");
        Temperature t = new Temperature(21.0);
        Console.WriteLine($"C: {t.Celsius}, F: {t.Fahrenheit:F1}");

        Console.WriteLine("Trying invalid temperature...");
        try
        {
            t.Celsius = -500.0;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Caught: {ex.GetType().Name}: {ex.Message}");
        }
    }
}
