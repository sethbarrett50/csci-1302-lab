using CS1302.Lab12.StacksQueues.Models;

namespace CS1302.Lab12.StacksQueues;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Stacks & Queues Practice ==");
        Console.WriteLine();

        Console.WriteLine("-- Balanced Parentheses (Stack) --");
        string[] samples = { "([]{})", "([)]", "((()))", "(]" };
        foreach (string sample in samples)
        {
            Console.WriteLine($"{sample} -> {BalancedParenthesesChecker.IsBalanced(sample)}");
        }

        Console.WriteLine();
        Console.WriteLine("-- Print Queue Simulator (Queue) --");
        PrintQueueSimulator printer = new PrintQueueSimulator();
        printer.Enqueue("resume.pdf");
        printer.Enqueue("syllabus.docx");
        printer.Enqueue("lab-report.pdf");

        while (printer.PendingCount > 0)
        {
            Console.WriteLine($"Printing: {printer.ProcessNext()}");
        }
    }
}
