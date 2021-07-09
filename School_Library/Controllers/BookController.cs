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
        public ActionResult Index(string sortOrder, string searchName)
        {
            List<BookModel> books = bookRepository.GetAllBooks();
            ViewBag.NameSortParam = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AuthorSortParam = sortOrder == "author" ? "author_desc" : "author";
            
            books = SortName(books, sortOrder);

            if (!string.IsNullOrEmpty(searchName))
            {
                books = bookRepository.GetNameBySearch(searchName);
            }

            return View("Index", books);
        }

        private List<BookModel> SortName(List<BookModel> book, string sortOrder)
        {
            switch (sortOrder)
            {
                case "name_desc":
                    return bookRepository.OrderByDescendingParameter(book, "Name");

                case "author_desc":
                    return bookRepository.OrderByDescendingParameter(book, "Author");

                case "author":
                    return bookRepository.OrderByAscendingParameter(book, "Author");
                    ;
                default:
                    return bookRepository.OrderByAscendingParameter(book, "Name");
            }
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

        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
        // GET: Book/Edit/5
        public ActionResult Edit(Guid id)
        {
            BookModel bookModel = bookRepository.GetBookById(id);
           
            return View("EditBook",bookModel);
        }

        [Authorize(Roles = "Admin")]
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
