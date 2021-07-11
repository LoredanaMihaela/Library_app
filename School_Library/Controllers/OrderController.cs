using School_Library.Models;
using School_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Library.Controllers
{
    public class OrderController : Controller
    {
        private readonly BookRepository bookRepository = new BookRepository();
        // GET: Order
        public ActionResult OrderBooks(string sortOrder)
        {
            List<BookModel> books = bookRepository.GetAllBooks();
            ViewBag.NameSortParam = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.AuthorSortParam = sortOrder == "author" ? "author_desc" : "author";

            books = SortName(books, sortOrder);

            return PartialView("_OrderResult", books);
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
    }
}