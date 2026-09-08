using CS1302.Lab17.Exceptions.Models;

namespace CS1302.Lab17.Exceptions;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Exceptions Practice ==");
        Console.WriteLine();

        RunCalculation(10, 2, "/");
        RunCalculation(10, 0, "/");
        RunCalculation(10, 2, "%");
    }

    private static void RunCalculation(int left, int right, string operatorSymbol)
    {
        Console.WriteLine($"Calculating {left} {operatorSymbol} {right}...");
        try
        {
            int result = SafeCalculator.Calculate(left, right, operatorSymbol);
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: cannot divide by zero.");
        }
        catch (InvalidOperatorException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Attempt logged.");
            Console.WriteLine();
        }
    }
}
