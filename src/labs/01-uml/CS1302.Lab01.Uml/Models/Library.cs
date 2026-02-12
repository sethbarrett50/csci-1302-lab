namespace CS1302.Lab01.Uml.Models;

public class Library
{
    public List<Book> Books { get; } = new List<Book>();

    public void AddBook(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException(nameof(book));
        }

        Books.Add(book);
    }

    public Book? FindByTitle(string title)
    {
        if (title == null)
        {
            throw new ArgumentNullException(nameof(title));
        }

        if (title.Trim().Length == 0)
        {
            return null;
        }

        for (int i = 0; i < Books.Count; i++)
        {
            Book b = Books[i];

            if (string.Equals(b.Title, title, StringComparison.OrdinalIgnoreCase))
            {
                return b;
            }
        }

        return null;
    }

    public void CheckOut(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException(nameof(book));
        }

        book.CheckOut();
    }

    public void Return(Book book)
    {
        if (book == null)
        {
            throw new ArgumentNullException(nameof(book));
        }

        book.Return();
    }
}
