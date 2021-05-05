using School_Library.Models;
using School_Library.Models.DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Repository
{
    public class BookRepository
    {
        private DataClasses1DataContext dbContext;

        public BookRepository()
        {
            dbContext = new DataClasses1DataContext();
        }
        public BookRepository(DataClasses1DataContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<BookModel> GetAllBooks()
        {
            List<BookModel> bookList = InitializeBookCollection();
            foreach (Book dbBook in dbContext.Books)
            {
                AddDbObjectToModelCollection(bookList, dbBook) ;
            }
            return bookList;
        }

       

        public BookModel GetBookById(Guid ID)
        {
            var book = dbContext.Books.FirstOrDefault(x => x.IdBook == ID);
            return MapDbObjectToModel(book);
        }

        internal List<BookModel> OrderByParameter(string param)
        {
            List<BookModel> bookList = InitializeBookCollection();
            foreach(Book dbBook in dbContext.Books)
            
                AddDbObjectToModelCollection(bookList, dbBook);
            
            if(param == "Name")
            
                return bookList.OrderBy(x => x.Name).ToList();
            
            if(param == "Author")
            
                return bookList.OrderBy(x => x.Author).ToList();
            
            return bookList;
        }

        internal List<BookModel> OrderByDescendingParameter(string param)
        {
            List<BookModel> bookList = InitializeBookCollection();
            foreach(Book dbBook in dbContext.Books)
                AddDbObjectToModelCollection(bookList, dbBook);
            
            if(param == "Name")
                return bookList.OrderByDescending(x => x.Name).ToList();
            
            if(param == "Author")
                return bookList.OrderByDescending(x => x.Author).ToList();
            
            return bookList;
        }

        public void InsertBook(BookModel book)
        {
            book.IDBook = Guid.NewGuid();

            dbContext.Books.InsertOnSubmit(MapModelToDbObject(book));
            dbContext.SubmitChanges();
        }



        public void UpdateBook(BookModel book)
        {
            Book bookDb = dbContext.Books.
                FirstOrDefault(x => x.IdBook == book.IDBook);
            if (bookDb != null)
            {
                bookDb.IdBook = book.IDBook;
                bookDb.Name = book.Name;
                bookDb.Author = book.Author;
                bookDb.Field = book.Field;
                bookDb.Description = book.Description;
                bookDb.NumbeOfBooksAvaible = book.NumberOfBooksAvaible;
                bookDb.NumberOfBooks = book.NumberOfBooks;
                dbContext.SubmitChanges();
            }
        }
        public void DeleteBook(Guid ID)
        {
            Book bookDb = dbContext.Books
                .FirstOrDefault(x => x.IdBook == ID);
            if (bookDb != null)
            {
                dbContext.Books.DeleteOnSubmit(bookDb);
                dbContext.SubmitChanges();
            }
        }


        private BookModel MapDbObjectToModel(Book dbBook)
        {
            BookModel book = new BookModel();
            if (dbBook != null)
            {
                book.IDBook = dbBook.IdBook;
                book.Name = dbBook.Name;
                book.Author = dbBook.Author;
                book.Field = dbBook.Field;
                book.Description = dbBook.Description;
                book.NumberOfBooksAvaible = dbBook.NumbeOfBooksAvaible;
                book.NumberOfBooks = dbBook.NumberOfBooks;
                return book;
            }
            return null;

        }

        private void AddDbObjectToModelCollection(
            List<BookModel> bookList, Book dbBook)
        {
            bookList.Add(MapDbObjectToModel(dbBook));
        }

        private List<BookModel> InitializeBookCollection()
        {
            return new List<BookModel>();
        }
        private Book MapModelToDbObject(BookModel book)
        {
            Book bookDb = new Book();
            if (book != null)
            {
                bookDb.IdBook = book.IDBook;
                bookDb.Name = book.Name;
                bookDb.Author = book.Author;
                bookDb.Field = book.Field;
                bookDb.Description = book.Description;
                bookDb.NumbeOfBooksAvaible = book.NumberOfBooksAvaible;
                bookDb.NumberOfBooks = book.NumberOfBooks;
                return bookDb;
            }
            return null;
        }
    }
}