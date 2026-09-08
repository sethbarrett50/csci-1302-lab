using CS1302.Lab13.Trees.Models;

namespace CS1302.Lab13.Trees;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("== Trees Practice ==");
        Console.WriteLine();

        BinarySearchTree tree = new BinarySearchTree();
        int[] values = { 50, 30, 70, 20, 40, 60, 80 };
        foreach (int value in values)
        {
            tree.Insert(value);
        }

        Console.WriteLine("In-order traversal (should be sorted):");
        Console.WriteLine(string.Join(", ", tree.InOrderTraversal()));

        Console.WriteLine();
        Console.WriteLine($"Contains 40: {tree.Contains(40)}");
        Console.WriteLine($"Contains 99: {tree.Contains(99)}");
    }
}
