/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [],
            temp,
            categories = [],
            newBooks = [];

        function validateBookAndCategoryName(name) {
            if (name.length < 2 || name.length > 100) {
                throw new Error;
            }
        }

        function validateBookAuthor(name) {
            if (name === '') {
                throw new Error;
            }
        }

        function validateBookISBN(isbn) {
            if ((isbn.length !== 10 || isbn.length !== 13) && !isNaN(isbn)) {
                throw new Error;
            }
        }

        function checkForTheSameBook(obj, arr) {
            for (var i = 0; i < arr.length; i++) {
                if ((arr[i].ISBN === obj.ISBN) || (arr[i].title === obj.title)) {
                    return true;
                }
            }
            return false;
        }


        function listBooks() {

            if (books.length === 0) {
                return [];
            }

            if (books.length === 1) {
                return [books[0]];
            }

            if (arguments !== undefined) {
                if (arguments[0].category !== undefined) {
                    temp = arguments[0].category;

                    for (var j = 0; j < books.length; j++) {
                        if (books[j].author === temp) {
                            newBooks.push(books[j]);
                        }
                    }

                    if (newBooks.length === 0) {
                        return [];
                    }
                    temp = '';
                }

                if (arguments[0].author !== undefined) {
                    temp = arguments[0].author;

                    for (var i = 0; i < books.length; i++) {
                        if (books[i].category === temp) {
                            newBooks.push(books[i]);
                        }
                    }

                    if (newBooks.length === 0) {
                        return [];
                    }
                    temp = '';
                }
            }

            books = books.sort(function (a, b) {
                return a.ID - b.ID;
            });

            return books;
        }

        function addBook(title, author, ISBN, category) {

            var newBook = {
                title: title,
                author: author,
                ISBN: ISBN,
                category: category,
                ID: books.length + 1
            };

            validateBookAndCategoryName(title);
            validateBookAndCategoryName(category);
            validateBookAuthor(author);
            validateBookISBN(ISBN);


            if (checkForTheSameBook(newBook, books)) {
                throw new Error;
            }

            books.push(newBook);
            categories.push(newBook.category);
            return books;
        }

        function listCategories() {

            if (categories.length === 0) {
                return [];
            }

            categories = categories.sort(function (a, b) {
                return a.ID - b.ID;
            });

            return categories;
        }


        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;
