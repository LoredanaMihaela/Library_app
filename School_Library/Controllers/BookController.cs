using School_Library.Models;
using School_Library.Models.DbObjects;
using School_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Library.Controllers
{
    public class BookController : Controller
    {
        private BookRepository bookRepository = new BookRepository();
        // GET: Book


        [AllowAnonymous]
        public ActionResult Index(string sortOrder)
        {
            ViewBag.NameSortParam = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AuthorSortParam = sortOrder == "author" ? "author_desc" : "author";
            var book =from b in bookRepository.GetAllBooks() select b;
            switch (sortOrder)
            {
                case "name_desc":
                    book = bookRepository.OrderByDescendingParameter("Name");
                    break;
                case "author_desc":
                    book = bookRepository.OrderByDescendingParameter("Author");
                    break;
                case "author":
                    book = bookRepository.OrderByParameter("Author");
                    break;
                default:
                    book = bookRepository.OrderByParameter("Name");
                    break;

            }

            //List < BookModel > books = bookRepository.GetAllBooks();
            //return View("Index",books);
            return View(book.ToList());
        }
        [AllowAnonymous]
        // GET: Book/Details/5
        public ActionResult Details(Guid id)
        {
            BookModel bookModel = bookRepository.GetBookById(id);
            return View("BookDetails", bookModel);
        }

        [Authorize(Roles = "User,Admin")]
        // GET: Book/Create
        public ActionResult Create()
        {
            return View("CreateBook");
        }

        [Authorize(Roles = "User,Admin")]
        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                BookModel bookModel = new BookModel();
                UpdateModel(bookModel);
                if (User.Identity.IsAuthenticated) 
                {
                    bookModel.Name = User.Identity.Name + ":" + bookModel.Name;
                    bookModel.Author = bookModel.Author + ":" + User.Identity.Name;

                }
                bookRepository.InsertBook(bookModel);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateBook");
            }
        }

        [Authorize(Roles = "User,Admin")]
        // GET: Book/Edit/5
        public ActionResult Edit(Guid id)
        {
            BookModel bookModel = bookRepository.GetBookById(id);
           
            return View("EditBook",bookModel);
        }

        [Authorize(Roles = "User,Admin")]
        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                BookModel bookModel = new BookModel();
                UpdateModel(bookModel);
                bookRepository.UpdateBook(bookModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditBook");
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: Book/Delete/5
        public ActionResult Delete(Guid id)
        {
            BookModel bookModel = bookRepository.GetBookById(id);
            return View("DeleteBook",bookModel);
        }

        [Authorize(Roles = "Admin")]
        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                bookRepository.DeleteBook(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteBook");
            }
        }
    }
}
