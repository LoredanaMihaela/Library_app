using School_Library.Models;
using School_Library.Models.DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Repository
{
    public class BorrowedBookRepository
    {
        private DataClasses1DataContext dbContext;

        public BorrowedBookRepository()
        {
            dbContext = new DataClasses1DataContext();
        }
        public BorrowedBookRepository(DataClasses1DataContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<BorrowedBookModel> GetAllBorrowedBook()
        {
            List<BorrowedBookModel> borrowedBookList = InitializeBorrowedBookCollection();
            foreach (BorrowedBook dbBorrowedBook in dbContext.BorrowedBooks)
            {
                AddDbObjectToModelCollection(borrowedBookList, dbBorrowedBook); ;
            }
            return borrowedBookList;
        }
        public BorrowedBookModel GetBorrowedBookById(Guid ID)
        {
            var borrowedBook = dbContext.BorrowedBooks.FirstOrDefault(x => x.IdBorrowedBook == ID);
            return MapDbObjectToModel(borrowedBook);
        }


        public void InsertBorrowedBook(BorrowedBookModel borrowedBook)
        {
            borrowedBook.IDBorrowedBook = Guid.NewGuid();

            dbContext.BorrowedBooks.InsertOnSubmit(MapModelToDbObject(borrowedBook));
            dbContext.SubmitChanges();
        }



        public void UpdateBorrowedBook(BorrowedBookModel borrowedBook)
        {
            BorrowedBook borrowedBookDb = dbContext.BorrowedBooks.
                 FirstOrDefault(x => x.IdBorrowedBook == borrowedBook.IDBorrowedBook);
            if (borrowedBookDb != null)
            {
                borrowedBookDb.IdBorrowedBook = borrowedBook.IDBorrowedBook;
                borrowedBookDb.IdBook = borrowedBook.IDBook;
                borrowedBookDb.IdUser = borrowedBook.IDUser;
                borrowedBookDb.ValildFrom = borrowedBook.ValidFrom;
                borrowedBookDb.ValidTo = borrowedBook.ValidTo;
                borrowedBookDb.IsReturned = borrowedBook.IsReturned;

                dbContext.SubmitChanges();
            }
        }
        public void DeleteBorrowedBook(Guid ID)
        {
            BorrowedBook borrowedBookDb = dbContext.BorrowedBooks
                 .FirstOrDefault(x => x.IdBorrowedBook == ID);
            if (borrowedBookDb != null)
            {
                dbContext.BorrowedBooks.DeleteOnSubmit(borrowedBookDb);
                dbContext.SubmitChanges();
            }
        }



        private BorrowedBookModel MapDbObjectToModel(BorrowedBook dbBorrowedBooks)
        {
            BorrowedBookModel borrowedBook = new BorrowedBookModel();
            if (dbBorrowedBooks != null)
            {
                borrowedBook.IDBorrowedBook = dbBorrowedBooks.IdBorrowedBook;
                borrowedBook.IDBook = dbBorrowedBooks.IdBook;
                borrowedBook.IDUser = dbBorrowedBooks.IdUser;
                borrowedBook.ValidFrom = dbBorrowedBooks.ValildFrom;
                borrowedBook.ValidTo = dbBorrowedBooks.ValidTo;
                borrowedBook.IsReturned = dbBorrowedBooks.IsReturned;
                return borrowedBook;
            }
            return null;

        }

        private void AddDbObjectToModelCollection(
            List<BorrowedBookModel> borrowedBookList, BorrowedBook dbBorrowedBooks)
        {
            borrowedBookList.Add(MapDbObjectToModel(dbBorrowedBooks));
        }

        private List<BorrowedBookModel> InitializeBorrowedBookCollection()
        {
            return new List<BorrowedBookModel>();
        }
        private BorrowedBook MapModelToDbObject(BorrowedBookModel borrowedBook)
        {
            BorrowedBook borrowedBookDb = new BorrowedBook();
            if (borrowedBook != null)
            {
                borrowedBookDb.IdBorrowedBook = borrowedBook.IDBorrowedBook;
                borrowedBookDb.IdBook = borrowedBook.IDBook;
                borrowedBookDb.IdUser = borrowedBook.IDUser;
                borrowedBookDb.ValildFrom = borrowedBook.ValidFrom;
                borrowedBookDb.ValidTo = borrowedBook.ValidTo;
                borrowedBookDb.IsReturned = borrowedBook.IsReturned;
                return borrowedBookDb;
            }
            return null;
        }
    }
}