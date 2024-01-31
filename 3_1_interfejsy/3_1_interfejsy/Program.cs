using _3_1_interfejsy.classess;

namespace _3_1_interfejsy;

internal class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>();

        books.Add(new Book("Hobbit", "Nowak", 1987, 49));
        books.Add(new Book("Hobbit2", "Pawlak", 1999, 49));
        books.Add(new Book("Hobbit3", "Arbuz", 1992,179));
        books.Add(new Book("Hobbit4", "Michał", 1979, 189));

        Console.WriteLine("Lista ksiażek: ");

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
        Console.WriteLine("\nPosortowana lista ksiażek według ceny: ");
        books.Sort();
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nPosortowana lista ksiażek według autora: ");
        var sortedByAuthor = books.OrderBy(book => book.Author);
        foreach (Book book in sortedByAuthor)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nPosortowana lista ksiażek według autora: ");
        var sortedByAuthorDesc = books.OrderByDescending(book => book.Author);
        foreach (Book book in sortedByAuthorDesc)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nPosortowana lista ksiażek według ceny,a potem roku: ");
        var sortedByPriceAndYear = books.OrderByDescending(book => book.Price).ThenBy(book => book.YearOfPublicatin);
        foreach (Book book in sortedByPriceAndYear)
        {
            Console.WriteLine(book);
        }

        Console.ReadKey();
    }
}

