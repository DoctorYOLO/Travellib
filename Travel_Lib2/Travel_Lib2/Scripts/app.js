var ViewModel = function () {
    var self = this;
    self.books = ko.observableArray();
    self.error = ko.observable();
    self.newBook = {
        BookName: ko.observable(),
        AuthorName: ko.observable(),
        Category: ko.observable(),
        Description: ko.observable(),
        BookImage: ko.observable()
    }
    self.bookToDelete = ko.observable();
    self.bookDetail = ko.observable();

    var booksUri = '/api/books/';

    function ajaxHelper(uri, method, data) {
        self.error(''); // Clear error message
        return $.ajax({
            type: method,
            url: uri,
            dataType: 'json',
            contentType: 'application/json',
            data: data ? JSON.stringify(data) : null
        }).fail(function (jqXHR, textStatus, errorThrown) {
            self.error(errorThrown);
        });
    }

    self.deleteBook = function (item) {
        ajaxHelper(booksUri + item.BookID, 'DELETE').done(function (data) {
            self.bookToDelete(data);
        });
    }

    function getAllBooks() {
        ajaxHelper(booksUri, 'GET').done(function (data) {
            self.books(data);
        });
    }

    self.addBook = function (formElement) {
        var book = {
            BookID: self.newBook.BookName().BookID,
            BookName: self.newBook.BookName(),
            AuthorName: self.newBook.AuthorName(),
            Category: self.newBook.Category(),
            Description: self.newBook.Description(),
            BookImage: self.newBook.BookImage()
        };

        ajaxHelper(booksUri, 'POST', book).done(function (item) {
            self.books.push(item);
        });

    }
    
    function getBookDtl(bID) {
        ajaxHelper(booksUri + bID, 'GET').done(function (data) {
            self.bookDetail(data);
        });
    }
    self.getBookDetail = function (item) {
        ajaxHelper(booksUri + item.BookID, 'GET').done(function (data) {
            self.bookDetail(data);
        });
    }

    // Fetch the initial data.
    getAllBooks();
};

ko.applyBindings(new ViewModel());