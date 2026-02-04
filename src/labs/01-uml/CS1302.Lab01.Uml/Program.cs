using CS1302.Lab01.Uml.Models;

namespace CS1302.Lab01.Uml;

public static class Program
{
    public static void Main()
    {
        var library = new Library();

        library.AddBook(new Book("Dune", "Frank Herbert"));
        library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien"));
        library.AddBook(new Book("Neuromancer", "William Gibson"));

        PrintStatus(library);

        Console.WriteLine();
        Console.WriteLine("Checking out 'Dune'...");
        var dune = library.FindByTitle("Dune");
        if (dune is not null)
        {
            library.CheckOut(dune);
        }

        PrintStatus(library);

        Console.WriteLine();
        Console.WriteLine("Returning 'Dune'...");
        if (dune is not null)
        {
            library.Return(dune);
        }

        PrintStatus(library);
    }

    private static void PrintStatus(Library library)
    {
        Console.WriteLine("Library Inventory:");
        foreach (var book in library.Books)
        {
            Console.WriteLine(
                $"- {book.Title} by {book.Author} (Checked out: {book.IsCheckedOut})"
            );
        }
    }
}
