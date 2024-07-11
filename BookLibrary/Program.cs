// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Library library = new Library();
library.LoadBooksFromJson();
Console.WriteLine($"Total books in library: {library.GetTotalBooks()}");