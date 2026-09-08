using CS1302.Lab13.Trees.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab13_Trees_Tests
{
    [Fact]
    public void InOrderTraversal_Returns_Sorted_Sequence()
    {
        BinarySearchTree tree = new BinarySearchTree();
        int[] values = { 50, 30, 70, 20, 40, 60, 80 };
        foreach (int value in values)
        {
            tree.Insert(value);
        }

        List<int> expected = new List<int>(values);
        expected.Sort();

        Assert.Equal(expected, tree.InOrderTraversal());
    }

    [Fact]
    public void Contains_Returns_False_For_Missing_Value()
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(10);
        tree.Insert(20);

        Assert.False(tree.Contains(99));
    }

    [Fact]
    public void Contains_Returns_True_For_Inserted_Value()
    {
        BinarySearchTree tree = new BinarySearchTree();
        tree.Insert(10);
        tree.Insert(20);
        tree.Insert(30);

        Assert.True(tree.Contains(20));
    }

    [Fact]
    public void Empty_Tree_Behaves_Safely()
    {
        BinarySearchTree tree = new BinarySearchTree();

        Assert.False(tree.Contains(1));
        Assert.Empty(tree.InOrderTraversal());
    }
}
