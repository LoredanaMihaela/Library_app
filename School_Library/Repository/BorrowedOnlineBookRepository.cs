using School_Library.Models;
using School_Library.Models.DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Repository
{
    public class BorrowedOnlineBookRepository
    {
        private DataClasses1DataContext dbContext;

        public BorrowedOnlineBookRepository()
        {
            dbContext = new DataClasses1DataContext();
        }
        public BorrowedOnlineBookRepository(DataClasses1DataContext _dbContext)
        {
            dbContext = _dbContext;
        }
       public List<BorrowedOnlineBookModel> GetAllBorrowedOnlineBooks()
        {
            List<BorrowedOnlineBookModel> borrowedOnlineBookList = InitializeBorrowedOnlineBookCollection();
            foreach(BorrowedOnlineBook dbBorrowedOnlineBook in dbContext.BorrowedOnlineBooks)
            {
                AddDbObjectToModelCollection(borrowedOnlineBookList, dbBorrowedOnlineBook);
            }
            return borrowedOnlineBookList;
        }
        public BorrowedOnlineBookModel GetBorrowedOnlineBookById(Guid ID)
        {
            var borrowedOnlineBook = dbContext.BorrowedOnlineBooks.FirstOrDefault(x => x.IdBorrowedOnlineBook == ID);
            return MapDbObjectToModel(borrowedOnlineBook);
        }

        public void InsertBorrowedOnlineBook(BorrowedOnlineBookModel borrowedOnlineBook)
        {
            borrowedOnlineBook.IDBorrowedOnlineBook = Guid.NewGuid();
            dbContext.BorrowedOnlineBooks.InsertOnSubmit(MapModelToDbObject(borrowedOnlineBook));
            dbContext.SubmitChanges();
        }

        

        public void UpdateBorrowedOnlineBook(BorrowedOnlineBookModel borrowedOnlineBook)
        {

            BorrowedOnlineBook borrowedOnlineBookDb = dbContext.BorrowedOnlineBooks.
                FirstOrDefault(x => x.IdBorrowedOnlineBook == borrowedOnlineBook.IDBorrowedOnlineBook);
            if(borrowedOnlineBookDb != null)
            {
                borrowedOnlineBookDb.IdBorrowedOnlineBook = borrowedOnlineBook.IDBorrowedOnlineBook;
                borrowedOnlineBookDb.IdOnlineBook = borrowedOnlineBook.IDOnlineBook;
                borrowedOnlineBookDb.IdUser = borrowedOnlineBook.IDUser;
                borrowedOnlineBookDb.ValidTo = borrowedOnlineBook.ValidTo;
                borrowedOnlineBookDb.ValildFrom = borrowedOnlineBook.ValidFrom;
                borrowedOnlineBookDb.IsAvable = borrowedOnlineBook.IsAvaible;
                dbContext.SubmitChanges();
            }
        }

        public void DeleteBorrowedOnlineBook(Guid ID)
        {
            BorrowedOnlineBook borrowedOnlineBookDb = dbContext.BorrowedOnlineBooks.
                FirstOrDefault(x => x.IdBorrowedOnlineBook == ID);
            if(borrowedOnlineBookDb != null)
            {
                dbContext.BorrowedOnlineBooks.DeleteOnSubmit(borrowedOnlineBookDb);
                dbContext.SubmitChanges();
            }
        }

       

        private BorrowedOnlineBook MapModelToDbObject(BorrowedOnlineBookModel borrowedOnlineBook)
        {
            BorrowedOnlineBook borrowedOnlineBookDb = new BorrowedOnlineBook();
            if(borrowedOnlineBook != null)
            {
                borrowedOnlineBookDb.IdBorrowedOnlineBook = borrowedOnlineBook.IDBorrowedOnlineBook;
                borrowedOnlineBookDb.IdOnlineBook = borrowedOnlineBook.IDOnlineBook;
                borrowedOnlineBookDb.IdUser = borrowedOnlineBook.IDUser;
                borrowedOnlineBookDb.ValidTo = borrowedOnlineBook.ValidTo;
                borrowedOnlineBookDb.ValildFrom = borrowedOnlineBook.ValidFrom;
                borrowedOnlineBookDb.IsAvable = borrowedOnlineBook.IsAvaible;
                return borrowedOnlineBookDb;
            }
            return null;
        }

        private BorrowedOnlineBookModel MapDbObjectToModel(BorrowedOnlineBook dbBorrowedOnlineBook)
        {
            BorrowedOnlineBookModel borrowedOnlineBook = new BorrowedOnlineBookModel();
            if( dbBorrowedOnlineBook != null)
            {
                borrowedOnlineBook.IDBorrowedOnlineBook = dbBorrowedOnlineBook.IdBorrowedOnlineBook;
                borrowedOnlineBook.IDOnlineBook = dbBorrowedOnlineBook.IdOnlineBook;
                borrowedOnlineBook.IDUser = dbBorrowedOnlineBook.IdUser;
                borrowedOnlineBook.ValidTo = dbBorrowedOnlineBook.ValidTo;
                borrowedOnlineBook.ValidFrom = dbBorrowedOnlineBook.ValildFrom;
                borrowedOnlineBook.IsAvaible = dbBorrowedOnlineBook.IsAvable;
                return borrowedOnlineBook;
            }
            return null;
        }
      

        private List<BorrowedOnlineBookModel> InitializeBorrowedOnlineBookCollection()
        {
            return new List<BorrowedOnlineBookModel>();
        }

        private void AddDbObjectToModelCollection(List<BorrowedOnlineBookModel> borrowedOnlineBookList, BorrowedOnlineBook dbBorrowedOnlineBook)
        {
            borrowedOnlineBookList.Add(MapDbObjectToModel(dbBorrowedOnlineBook));
        }
    }
}