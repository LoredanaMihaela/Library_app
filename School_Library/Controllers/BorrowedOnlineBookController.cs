using School_Library.Models;
using School_Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Library.Controllers
{
    public class BorrowedOnlineBookController : Controller
    {
        private BorrowedOnlineBookRepository borrowedOnlineBookRepository = new BorrowedOnlineBookRepository();
        // GET: BorrowedOnlineBook
        public ActionResult Index()
        {
            List<BorrowedOnlineBookModel> borrowedOnlineBook = borrowedOnlineBookRepository.GetAllBorrowedOnlineBooks();

            return View("Index",borrowedOnlineBook);
        }

        // GET: BorrowedOnlineBook/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BorrowedOnlineBook/Create
        public ActionResult Create()
        {
            return View("CreateBorrowedOnlineBook");
        }

        // POST: BorrowedOnlineBook/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                BorrowedOnlineBookModel borrowedOnlineBookModel = new BorrowedOnlineBookModel();
                UpdateModel(borrowedOnlineBookModel);
                borrowedOnlineBookRepository.InsertBorrowedOnlineBook(borrowedOnlineBookModel);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("CreateBorrowedOnlineBook");
            }
        }

        // GET: BorrowedOnlineBook/Edit/5
        public ActionResult Edit(Guid id)
        {
            BorrowedOnlineBookModel borrowedOnlineBookModel = borrowedOnlineBookRepository.GetBorrowedOnlineBookById(id);
            return View("EditBorrowedOnlineBook", borrowedOnlineBookModel);
        }

        // POST: BorrowedOnlineBook/Edit/5
        [HttpPost]
        public ActionResult Edit(Guid id, FormCollection collection)
        {
            try
            {
                BorrowedOnlineBookModel borrowedOnlineBookModel = new BorrowedOnlineBookModel();
                UpdateModel(borrowedOnlineBookModel);
                borrowedOnlineBookRepository.UpdateBorrowedOnlineBook(borrowedOnlineBookModel);

                

                return RedirectToAction("Index");
            }
            catch
            {
                return View("EditBorrowedOnlineBook");
            }
        }

        // GET: BorrowedOnlineBook/Delete/5
        public ActionResult Delete(Guid id)
        {
            BorrowedOnlineBookModel borrowedOnlineBookModel = borrowedOnlineBookRepository.GetBorrowedOnlineBookById(id);

            return View("DeleteBorrowedOnlineBook",borrowedOnlineBookModel);
        }

        // POST: BorrowedOnlineBook/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                borrowedOnlineBookRepository.DeleteBorrowedOnlineBook(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("DeleteBorrowedOnlineBook");
            }
        }
    }
}
