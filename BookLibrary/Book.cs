public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }
}