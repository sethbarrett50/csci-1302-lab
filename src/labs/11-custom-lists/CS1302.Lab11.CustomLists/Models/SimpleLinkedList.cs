using System.Collections;

namespace CS1302.Lab11.CustomLists.Models;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;

        public Node(T value)
        {
            Value = value;
        }
    }

    private Node? _head;
    private Node? _tail;

    public int Count { get; private set; }

    public void Add(T value)
    {
        Node node = new Node(value);

        if (_head == null)
        {
            _head = node;
            _tail = node;
        }
        else
        {
            _tail!.Next = node;
            _tail = node;
        }

        Count++;
    }

    public bool RemoveFirst()
    {
        if (_head == null)
        {
            return false;
        }

        _head = _head.Next;
        if (_head == null)
        {
            _tail = null;
        }

        Count--;
        return true;
    }

    public bool Contains(T value)
    {
        Node? current = _head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node? current = _head;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
