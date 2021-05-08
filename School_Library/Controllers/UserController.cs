using School_Library.Models;
using School_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Library.Controllers
{
    public class UserController : Controller
    {
        private UserRepository userRepository = new UserRepository();
        // GET: User

        [AllowAnonymous]
        public ActionResult Index(string sortOrder)
        {
            ViewBag.FirstNameSortParam = string.IsNullOrEmpty(sortOrder) ? "FirstName_desc" : "";
            ViewBag.LastNameSortParam = sortOrder == "LastName" ? "LastName_desc" : "LastName";
            var user = from u in userRepository.GetAllUserss() select u;
            switch (sortOrder)
            {
                case "FirstName_desc":
                    user = userRepository.OrderByDescendingParameter("FirstName");
                    break;
                case "LastName_desc":
                    user = userRepository.OrderByDescendingParameter("LastName");
                    break;
                case "LastName":
                    user = userRepository.OrderByParameter("LastName");
                    break;
                default:
                    user = userRepository.OrderByParameter("FirstName");
                    break;

            }
            return View(user.ToList());

           
        }
        [AllowAnonymous]
        // GET: User/Details/5
        public ActionResult Details(Guid id)
        {
            UserModel userModel = userRepository.GetUserById(id);
            return View("DetailsUser",userModel);
        }

        [Authorize(Roles = "Admin")]
        // GET: User/Create
        public ActionResult Create()
        {
            return View("CreateUser");
        }

        [Authorize(Roles = "Admin")]
        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                UserModel userModel = new UserModel();
                UpdateModel(userModel);
                userRepository.InsertUser(userModel);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateUser");
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: User/Edit/5
        public ActionResult Edit(Guid id)
        {
            UserModel userModel = userRepository.GetUserById(id);
            return View("EditUser",userModel);
        }

        [Authorize(Roles = "Admin")]
        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                UserModel userModel = new UserModel();
                UpdateModel(userModel);
                userRepository.UpdateUser(userModel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditUser");
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: User/Delete/5
        public ActionResult Delete(Guid id)
        {
            UserModel userModel = userRepository.GetUserById(id);
            return View("DeleteUser",userModel);
        }

        [Authorize(Roles = "Admin")]
        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                userRepository.DeleteUser(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteUser");
            }
        }
    }
}
