using School_Library.Models;
using School_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Library.Controllers
{
    public class OnlineBookController : Controller
    {
        private OnlineBookRepository onlineBookRepository = new OnlineBookRepository();
        // GET: OnlineBook

        [AllowAnonymous]
        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParam = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AuthorSortParam = sortOrder == "author" ? "author_desc" : "author";
            var onlineBook = from b in onlineBookRepository.GetAllOnlineBooks() select b;
            switch (sortOrder)
            {
                case "name_desc":
                    onlineBook = onlineBookRepository.OrderByDescendingParameter("Name");
                    break;
                case "author_desc":
                    onlineBook = onlineBookRepository.OrderByDescendingParameter("Author");
                    break;
                case "author":
                    onlineBook = onlineBookRepository.OrderByParameter("Author");
                    break;
                default:
                    onlineBook = onlineBookRepository.OrderByParameter("Name");
                    break;

            }
            return View(onlineBook.ToList());
            
        }
        [AllowAnonymous]
        // GET: OnlineBook/Details/5
        public ActionResult Details(Guid id)
        {
            OnlineBookModel onlineBookModel = onlineBookRepository.GetOnlineBookById(id);
            return View("OnlineBookDetails",onlineBookModel);
        }

        [Authorize(Roles = "Admin")]
        // GET: OnlineBook/Create
        public ActionResult Create()
        {
            return View("CreateOnlineBook");
        }

        [Authorize(Roles = "Admin")]
        // POST: OnlineBook/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                OnlineBookModel onlineBookModel = new OnlineBookModel();
                UpdateModel(onlineBookModel);
                onlineBookRepository.InsertOnlineBook(onlineBookModel);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateOnlineBook");
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: OnlineBook/Edit/5
        public ActionResult Edit(Guid id)
        {
            OnlineBookModel onlineBookModel = onlineBookRepository.GetOnlineBookById(id);

            return View("EditOnlineBook", onlineBookModel);
        }

        [Authorize(Roles = "Admin")]
        // POST: OnlineBook/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                OnlineBookModel onlineBookModel = new OnlineBookModel();
                UpdateModel(onlineBookModel);
                onlineBookRepository.UpdateOnlineBook(onlineBookModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditOnlineBook");
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: OnlineBook/Delete/5
        public ActionResult Delete(Guid id)
        {
            OnlineBookModel onlineBookModel = onlineBookRepository.GetOnlineBookById(id);

            return View("DeleteOnlineBook", onlineBookModel);
        }

        [Authorize(Roles = "Admin")]
        // POST: OnlineBook/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                onlineBookRepository.DeleteOnlineBook(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteOnlineBook");
            }
        }
    }
}
