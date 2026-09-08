namespace CS1302.Lab13.Trees.Models;

public class BinarySearchTree
{
    private class Node
    {
        public int Value;
        public Node? Left;
        public Node? Right;

        public Node(int value)
        {
            Value = value;
        }
    }

    private Node? _root;

    public void Insert(int value)
    {
        _root = InsertNode(_root, value);
    }

    private static Node InsertNode(Node? node, int value)
    {
        if (node == null)
        {
            return new Node(value);
        }

        if (value < node.Value)
        {
            node.Left = InsertNode(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = InsertNode(node.Right, value);
        }

        return node;
    }

    public bool Contains(int value)
    {
        Node? current = _root;
        while (current != null)
        {
            if (value == current.Value)
            {
                return true;
            }

            current = value < current.Value ? current.Left : current.Right;
        }

        return false;
    }

    public List<int> InOrderTraversal()
    {
        List<int> results = new List<int>();
        InOrderTraversal(_root, results);
        return results;
    }

    private static void InOrderTraversal(Node? node, List<int> results)
    {
        if (node == null)
        {
            return;
        }

        InOrderTraversal(node.Left, results);
        results.Add(node.Value);
        InOrderTraversal(node.Right, results);
    }
}
