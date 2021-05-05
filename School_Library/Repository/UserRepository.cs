using School_Library.Models;
using School_Library.Models.DbObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Repository
{
    public class UserRepository
    {
        private DataClasses1DataContext dbContext;

        public UserRepository()
        {
            dbContext = new DataClasses1DataContext();
        }
        public UserRepository(DataClasses1DataContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public List<UserModel> GetAllUserss()
        {
            List<UserModel> userList = InitializeUserCollection();
            foreach (User dbUser in dbContext.Users)
            {
                AddDbObjectToModelCollection(userList, dbUser); ;
            }
            return userList;
        }

        internal List<UserModel> OrderByDescendingParameter(string param)
        {
            List<UserModel> userList = InitializeUserCollection();
            foreach (User dbUser in dbContext.Users)
                AddDbObjectToModelCollection(userList, dbUser);

            if (param == "FirstName")
                return userList.OrderByDescending(x => x.FirstName).ToList();

            if (param == "LastName")
                return userList.OrderByDescending(x => x.LastName).ToList();

            return userList;
        }

        internal List<UserModel> OrderByParameter(string param)
        {
            List<UserModel> userList = InitializeUserCollection();
            foreach (User dbUser in dbContext.Users)

                AddDbObjectToModelCollection(userList, dbUser);

            if (param == "FirstName")

                return userList.OrderBy(x => x.FirstName).ToList();

            if (param == "LastName")

                return userList.OrderBy(x => x.LastName).ToList();

            return userList;
        }

        public UserModel GetUserById(Guid ID)
        {
            var user = dbContext.Users.FirstOrDefault(x => x.IdUser == ID);
            return MapDbObjectToModel(user);
        }

       

        public void InsertUser(UserModel user)
        {
            user.IDUser = Guid.NewGuid();

            dbContext.Users.InsertOnSubmit(MapModelToDbObject(user));
            dbContext.SubmitChanges();
        }



        public void UpdateUser(UserModel user)
        {
            User userDb = dbContext.Users.
                 FirstOrDefault(x => x.IdUser == user.IDUser);
            if (userDb != null)
            {
                userDb.IdUser = user.IDUser;
                userDb.FirstName = user.FirstName;
                userDb.LastName = user.LastName;
                userDb.RegistrationDate = user.RegistrationDate;
                userDb.PhoneNr = user.PhoneNr;
                userDb.Email = user.Email;
                userDb.Adress = user.Adress;
                dbContext.SubmitChanges();
            }
        }
        public void DeleteUser(Guid ID)
        {
            User userDb = dbContext.Users
                 .FirstOrDefault(x => x.IdUser == ID);
            if (userDb != null)
            {
                dbContext.Users.DeleteOnSubmit(userDb);
                dbContext.SubmitChanges();
            }
        }


        private UserModel MapDbObjectToModel(User dbUser)
        {
            UserModel user = new UserModel();
            if (dbUser != null)
            {
                user.IDUser = dbUser.IdUser;
                user.FirstName = dbUser.FirstName;
                user.LastName = dbUser.LastName;
                user.RegistrationDate = dbUser.RegistrationDate;
                user.PhoneNr = dbUser.PhoneNr;
                user.Email = dbUser.Email;
                user.Adress = dbUser.Adress;
                return user;
            }
            return null;

        }

        private void AddDbObjectToModelCollection(
            List<UserModel> userList, User dbUser)
        {
            userList.Add(MapDbObjectToModel(dbUser));
        }

        private List<UserModel> InitializeUserCollection()
        {
            return new List<UserModel>();
        }
        private User MapModelToDbObject(UserModel user)
        {
            User userDb = new User();
            if (user != null)
            {
                userDb.IdUser = user.IDUser;
                userDb.FirstName = user.FirstName;
                userDb.LastName = user.LastName;
                userDb.RegistrationDate = user.RegistrationDate;
                userDb.PhoneNr = user.PhoneNr;
                userDb.Email = user.Email;
                userDb.Adress = user.Adress;
                return userDb;
            }
            return null;
        }
    }
}