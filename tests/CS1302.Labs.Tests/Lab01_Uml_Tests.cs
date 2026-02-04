using CS1302.Lab01.Uml.Models;
using Xunit;

namespace CS1302.Labs.Tests;

public sealed class Lab01_Uml_Tests
{
    [Fact]
    public void Book_CheckOut_Then_Return_Works()
    {
        var book = new Book("Dune", "Frank Herbert");

        Assert.False(book.IsCheckedOut);

        book.CheckOut();
        Assert.True(book.IsCheckedOut);

        book.Return();
        Assert.False(book.IsCheckedOut);
    }

    [Fact]
    public void Library_FindByTitle_IsCaseInsensitive()
    {
        var lib = new Library();
        lib.AddBook(new Book("Dune", "Frank Herbert"));

        var found = lib.FindByTitle("dUnE");
        Assert.NotNull(found);
        Assert.Equal("Dune", found!.Title);
    }
}
