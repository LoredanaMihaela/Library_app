using School_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Library.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookRepository bookRepository = new BookRepository();

        public ActionResult SearchBooks(string searchCriteria)
        {
            var books = bookRepository.GetBooksBySearchCriteria(searchCriteria);
            return PartialView("_SearchResult", books);
        }

        public ActionResult GetAll()
        {
            var books = bookRepository.GetAllBooks();
            return PartialView("_SearchResult", books);
        }
    }
}