using NUnit.Framework;

[TestFixture]
public class LibraryTests
{
    [Test]
    public void AddBook_IncreasesTotalBooks()
    {
        
        Library library = new Library();
        Book book = new Book("1234567890", "Generic Book Name", "Generic Author Name");

        
        library.AddBook(book);

        Assert.AreEqual(1, library.GetTotalBooks());
    }

    [Test]
    public void FindBookByISBN_ReturnsCorrectBook()
    {
        
        Library library = new Library();
        Book book = new Book("1234567890", "Generic Book Name", "Generic Author Name");
        library.AddBook(book);

        Book foundBook = library.FindBookByISBN("1234567890");

       
        Assert.IsNotNull(foundBook);
        Assert.AreEqual("Generic Book Name", foundBook.Title);
        Assert.AreEqual("Generic Author Name", foundBook.Author);
    }

    [Test]
    public void FindBooksByAuthor_ReturnsCorrectBooks()
    {
        Library library = new Library();
        Book book1 = new Book("1234567890", "Generic Book Name 1", "Generic Author Name");
        Book book2 = new Book("0987654321", "Generic Book Name 2", "Another Author");
        Book book3 = new Book("1122334455", "Generic Book Name 3", "Generic Author Name");
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        List<Book> foundBooks = library.FindBooksByAuthor("Generic Author Name");

        Assert.AreEqual(2, foundBooks.Count);
        Assert.IsTrue(foundBooks.Exists(b => b.ISBN == "1234567890"));
        Assert.IsTrue(foundBooks.Exists(b => b.ISBN == "1122334455"));
    }
}



[TestFixture]
public class LibraryIntegrationTests
{
    [Test]
    public void AddMultipleBooks_FindByAuthor_ReturnsCorrectBooks()
    {
        Library library = new Library();
        Book book1 = new Book("1234567890", "Generic Book Name 1", "Generic Author Name");
        Book book2 = new Book("0987654321", "Generic Book Name 2", "Generic Author Name");
        library.AddBook(book1);
        library.AddBook(book2);

         
        List<Book> foundBooks = library.FindBooksByAuthor("Generic Author Name");

         
        Assert.AreEqual(2, foundBooks.Count);
        Assert.IsTrue(foundBooks.Exists(b => b.ISBN == "1234567890"));
        Assert.IsTrue(foundBooks.Exists(b => b.ISBN == "0987654321"));
    }

    [Test]
    public void AddBook_FindByISBN_ReturnsCorrectBook()
    {
        // Arrange
        Library library = new Library();
        Book book = new Book("1234567890", "Generic Book Name", "Generic Author Name");
        library.AddBook(book);

         
        Book foundBook = library.FindBookByISBN("1234567890");

         
        Assert.IsNotNull(foundBook);
        Assert.AreEqual("Generic Book Name", foundBook.Title);
        Assert.AreEqual("Generic Author Name", foundBook.Author);
    }
}


[TestFixture]
public class LibrarySystemE2ETests
{
    [Test]
    public void CreateLibrary_AddBooks_SearchAndRetrieveBooks()
    {
        // Arrange
        Library library = new Library();
        Book book1 = new Book("1234567890", "Generic Book Name 1", "Generic Author Name");
        Book book2 = new Book("0987654321", "Generic Book Name 2", "Another Author");
        library.AddBook(book1);
        library.AddBook(book2);

         
        Book foundBook = library.FindBookByISBN("1234567890");
        List<Book> foundBooksByAuthor = library.FindBooksByAuthor("Another Author");

         
        Assert.IsNotNull(foundBook);
        Assert.AreEqual("Generic Book Name 1", foundBook.Title);

        Assert.AreEqual(1, foundBooksByAuthor.Count);
        Assert.AreEqual("0987654321", foundBooksByAuthor[0].ISBN);
    }

    
}
