Initialise node project

npm init -y

Make sure jest is installed

npm install --save-dev jest

Update package.json for testing:

{
  "scripts": {
    "test": "jest"
  }
}

run the tests

npm test

How to seed the data:

const { Library } = require('./library');

const library = new Library();
library.loadBooksFromJson('books_seed_data.json');
console.log(`Total books in library: ${library.getTotalBooks()}`);