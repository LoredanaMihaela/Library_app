using School_Library.Models;
using School_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Library.Controllers
{
    public class BorrowedBookController : Controller
    {
        private BorrowedBookRepository borrowedBookRepository = new BorrowedBookRepository();
        // GET: BorrowedBook

        [AllowAnonymous]
        public ActionResult Index()
        {
            List<BorrowedBookModel> borrowedBook = borrowedBookRepository.GetAllBorrowedBook();
            return View("Index",borrowedBook);
        }


        [AllowAnonymous]
        // GET: BorrowedBook/Details/5
        public ActionResult Details(Guid id)
        {
            BorrowedBookModel borrowedBookModel = borrowedBookRepository.GetBorrowedBookById(id);
            return View("BorrowedBookDetails", borrowedBookModel);
        }

        [Authorize(Roles ="User,Admin")]
        // GET: BorrowedBook/Create
        public ActionResult Create()
        {
            return View("CreateBorrowedBook");
        }

        [Authorize(Roles = "User,Admin")]
        // POST: BorrowedBook/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                BorrowedBookModel borrowedBookModel = new BorrowedBookModel();
                UpdateModel(borrowedBookModel);
                borrowedBookRepository.InsertBorrowedBook(borrowedBookModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateBorrowedBook");
            }
        }

        [Authorize(Roles = "User,Admin")]
        // GET: BorrowedBook/Edit/5
        public ActionResult Edit(Guid id)
        {
            BorrowedBookModel borrowedBookModel = borrowedBookRepository.GetBorrowedBookById(id);
            return View("EditBorrowedBook", borrowedBookModel);
        }

        [Authorize(Roles = "User,Admin")]
        // POST: BorrowedBook/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                BorrowedBookModel borrowedBookModel = new BorrowedBookModel();
                UpdateModel(borrowedBookModel);
                borrowedBookRepository.UpdateBorrowedBook(borrowedBookModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditBorrowedBook");
            }
        }

        [Authorize(Roles = "Admin")]
        // GET: BorrowedBook/Delete/5
        public ActionResult Delete(Guid id)
        {
            BorrowedBookModel borrowedBookModel = borrowedBookRepository.GetBorrowedBookById(id);
            return View("DeleteBorrowedBook", borrowedBookModel);
        }

        [Authorize(Roles = "Admin")]
        // POST: BorrowedBook/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                borrowedBookRepository.DeleteBorrowedBook(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteBorrowedBook");
            }
        }
    }
}
