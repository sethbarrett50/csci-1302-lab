using CS1302.Lab11.CustomLists.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public class Lab11_CustomLists_Tests
{
    [Fact]
    public void Empty_List_Behaves_Safely()
    {
        SimpleLinkedList<int> list = new SimpleLinkedList<int>();

        Assert.Equal(0, list.Count);
        Assert.False(list.Contains(1));
        Assert.False(list.RemoveFirst());
    }

    [Fact]
    public void Add_Increases_Count_And_Preserves_Order()
    {
        SimpleLinkedList<int> list = new SimpleLinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);

        Assert.Equal(3, list.Count);
        Assert.Equal(new[] { 1, 2, 3 }, list.ToList());
    }

    [Fact]
    public void RemoveFirst_Removes_Oldest_Added_Item()
    {
        SimpleLinkedList<string> list = new SimpleLinkedList<string>();
        list.Add("a");
        list.Add("b");

        bool removed = list.RemoveFirst();

        Assert.True(removed);
        Assert.Equal(1, list.Count);
        Assert.Equal(new[] { "b" }, list.ToList());
    }

    [Fact]
    public void Contains_Finds_Existing_Value()
    {
        SimpleLinkedList<int> list = new SimpleLinkedList<int>();
        list.Add(42);

        Assert.True(list.Contains(42));
        Assert.False(list.Contains(7));
    }
}
