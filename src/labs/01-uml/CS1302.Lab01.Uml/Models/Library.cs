namespace CS1302.Lab01.Uml.Models;

public sealed class Library
{
    private readonly List<Book> _books = new();

    public IReadOnlyList<Book> Books => _books;

    public void AddBook(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);
        _books.Add(book);
    }

    public Book? FindByTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return null;
        }

        return _books.FirstOrDefault(b =>
            string.Equals(b.Title, title, StringComparison.OrdinalIgnoreCase)
        );
    }

    public void CheckOut(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);
        book.CheckOut();
    }

    public void Return(Book book)
    {
        ArgumentNullException.ThrowIfNull(book);
        book.Return();
    }
}
