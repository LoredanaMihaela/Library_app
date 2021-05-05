using School_Library.Models;
using School_Library.Models.DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Repository
{
    public class OnlineBookRepository
    {
        private DataClasses1DataContext dbContext;

        public OnlineBookRepository()
        {
            dbContext = new DataClasses1DataContext();
        }
        public OnlineBookRepository(DataClasses1DataContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<OnlineBookModel> GetAllOnlineBooks()
        {
            List<OnlineBookModel> onlineBookList = InitializeOnlineBookCollection();
            foreach (OnlineBook dbOnlineBook in dbContext.OnlineBooks)
            {
                AddDbObjectToModelCollection(onlineBookList, dbOnlineBook); ;
            }
            return onlineBookList;
        }

      

        public OnlineBookModel GetOnlineBookById(Guid ID)
        {
            var onlineBook = dbContext.OnlineBooks.FirstOrDefault(x => x.IdOnlineBook == ID);
            return MapDbObjectToModel(onlineBook);
        }

        internal List<OnlineBookModel> OrderByParameter(string param)
        {
            List<OnlineBookModel> onlineBookList = InitializeOnlineBookCollection();
            foreach (OnlineBook dbOnlineBook in dbContext.OnlineBooks)

                AddDbObjectToModelCollection(onlineBookList, dbOnlineBook);

            if (param == "Name")

                return onlineBookList.OrderBy(x => x.Name).ToList();

            if (param == "Author")

                return onlineBookList.OrderBy(x => x.Author).ToList();

            return onlineBookList;
        }
        internal List<OnlineBookModel> OrderByDescendingParameter(string param)
        {
            List<OnlineBookModel> onlineBookList = InitializeOnlineBookCollection();
            foreach (OnlineBook dbOnlineBook in dbContext.OnlineBooks)
                AddDbObjectToModelCollection(onlineBookList, dbOnlineBook);

            if (param == "Name")
                return onlineBookList.OrderByDescending(x => x.Name).ToList();

            if (param == "Author")
                return onlineBookList.OrderByDescending(x => x.Author).ToList();

            return onlineBookList;
        }

        public void InsertOnlineBook(OnlineBookModel onlineBook)
        {
            onlineBook.IDOnlineBook = Guid.NewGuid();

            dbContext.OnlineBooks.InsertOnSubmit(MapModelToDbObject(onlineBook));
            dbContext.SubmitChanges();
        }



        public void UpdateOnlineBook(OnlineBookModel onlineBook)
        {
            OnlineBook onlineBookDb = dbContext.OnlineBooks.
                FirstOrDefault(x => x.IdOnlineBook == onlineBook.IDOnlineBook);
            if (onlineBookDb != null)
            {
                onlineBookDb.IdOnlineBook = onlineBook.IDOnlineBook;
                onlineBookDb.Name = onlineBook.Name;
                onlineBookDb.Author = onlineBook.Author;
                onlineBookDb.Field = onlineBook.Field;
                onlineBookDb.Description = onlineBook.Description;
                onlineBookDb.IsAvaible = onlineBook.IsAvaible;

                dbContext.SubmitChanges();
            }
        }
        public void DeleteOnlineBook(Guid ID)
        {
            OnlineBook onlineBookDb = dbContext.OnlineBooks
                .FirstOrDefault(x => x.IdOnlineBook == ID);
            if (onlineBookDb != null)
            {
                dbContext.OnlineBooks.DeleteOnSubmit(onlineBookDb);
                dbContext.SubmitChanges();
            }
        }

        private void AddDbObjectToModelCollection(List<OnlineBookModel> onlineBookList, OnlineBook dbOnlineBook)
        {
            onlineBookList.Add(MapDbObjectToModel(dbOnlineBook));
        }


        private OnlineBookModel MapDbObjectToModel(OnlineBook dbOnlineBook)
        {
            OnlineBookModel onlineBook = new OnlineBookModel();
            if (dbOnlineBook != null)
            {
                onlineBook.IDOnlineBook = dbOnlineBook.IdOnlineBook;
                onlineBook.Name = dbOnlineBook.Name;
                onlineBook.Author = dbOnlineBook.Author;
                onlineBook.Field = dbOnlineBook.Field;
                onlineBook.Description = dbOnlineBook.Description;
                onlineBook.IsAvaible = dbOnlineBook.IsAvaible;
                return onlineBook;
            }
            return null;
        }
        private List<OnlineBookModel> InitializeOnlineBookCollection()
        {
            return new List<OnlineBookModel>();
        }

        private OnlineBook MapModelToDbObject(OnlineBookModel onlineBook)
        {
            OnlineBook onlineBookDb = new OnlineBook();
            if (onlineBook != null)
            {
                onlineBookDb.IdOnlineBook = onlineBook.IDOnlineBook;
                onlineBookDb.Name = onlineBook.Name;
                onlineBookDb.Author = onlineBook.Author;
                onlineBookDb.Field = onlineBook.Field;
                onlineBookDb.Description = onlineBook.Description;
                onlineBookDb.IsAvaible = onlineBook.IsAvaible;

                return onlineBookDb;
            }
            return null;
        }
    }
}