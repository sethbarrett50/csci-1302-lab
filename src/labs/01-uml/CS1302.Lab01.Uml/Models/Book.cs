namespace CS1302.Lab01.Uml.Models;

public class Book
{
    public Book(string title, string author)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Author = author ?? throw new ArgumentNullException(nameof(author));
        IsCheckedOut = false;
    }

    public string Title { get; }

    public string Author { get; }

    public bool IsCheckedOut { get; private set; }

    public void CheckOut()
    {
        if (IsCheckedOut)
        {
            throw new InvalidOperationException("Book is already checked out.");
        }

        IsCheckedOut = true;
    }

    public void Return()
    {
        if (!IsCheckedOut)
        {
            throw new InvalidOperationException("Book is not checked out.");
        }

        IsCheckedOut = false;
    }
}
