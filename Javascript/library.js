// library.js
const fs = require('fs');

class Library {
  constructor() {
    this.books = [];
  }

  addBook(book) {
    this.books.push(book);
  }

  findBookByISBN(isbn) {
    return this.books.find(book => book.isbn === isbn);
  }

  findBooksByAuthor(author) {
    return this.books.filter(book => 
      book.author.toLowerCase().includes(author.toLowerCase())
    );
  }

  getTotalBooks() {
    return this.books.length;
  }

  loadBooksFromJson(jsonFilePath) {
    try {
      const jsonString = fs.readFileSync(jsonFilePath, 'utf8');
      const loadedBooks = JSON.parse(jsonString);
      loadedBooks.forEach(bookData => {
        this.addBook(new Book(bookData.isbn, bookData.title, bookData.author));
      });
      console.log(`Successfully loaded ${loadedBooks.length} books from JSON.`);
    } catch (error) {
      console.error(`Error loading books from JSON: ${error.message}`);
    }
  }
}

module.exports = { Book, Library };