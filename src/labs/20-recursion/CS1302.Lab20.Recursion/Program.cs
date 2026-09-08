using CS1302.Lab20.Recursion.Models;

namespace CS1302.Lab20.Recursion;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Recursion Practice ==");
        Console.WriteLine();

        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Sum of [{string.Join(", ", numbers)}] = {RecursiveMath.Sum(numbers)}");

        Console.WriteLine();
        string word = "recursion";
        Console.WriteLine($"Reverse of \"{word}\" = \"{RecursiveMath.Reverse(word)}\"");

        Console.WriteLine();
        for (int n = 0; n <= 10; n++)
        {
            Console.WriteLine($"Fibonacci({n}) = {RecursiveMath.Fibonacci(n)}");
        }

        Console.WriteLine();
        Console.WriteLine("Try raising this number and watch it slow down noticeably:");
        int slowN = 32;
        Console.WriteLine($"Fibonacci({slowN}) = {RecursiveMath.Fibonacci(slowN)}");
    }
}
