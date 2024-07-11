using System.Collections.Generic;
using System.Text.Json;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public Book FindBookByISBN(string isbn)
    {
        return books.Find(book => book.ISBN == isbn);
    }

    public List<Book> FindBooksByAuthor(string author)
    {
        return books.FindAll(book => book.Author.ToLower().Contains(author.ToLower()));
    }

    public int GetTotalBooks()
    {
        return books.Count;
    }

    public void LoadBooksFromJson(string jsonFilePath)
    {
        try
        {
            string jsonString = File.ReadAllText(jsonFilePath);
            List<Book> loadedBooks = JsonSerializer.Deserialize<List<Book>>(jsonString);
            books.AddRange(loadedBooks);
            Console.WriteLine($"Successfully loaded {loadedBooks.Count} books from JSON.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading books from JSON: {ex.Message}");
        }
    }

    public void LoadBooksFromJson()
    {
        var hardCodedJsonPath = "./seed_data.json";
        try
        {
            string jsonString = File.ReadAllText(hardCodedJsonPath);
            List<Book> loadedBooks = JsonSerializer.Deserialize<List<Book>>(jsonString);
            books.AddRange(loadedBooks);
            Console.WriteLine($"Successfully loaded {loadedBooks.Count} books from JSON.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading books from JSON: {ex.Message}");
        }
    }
}