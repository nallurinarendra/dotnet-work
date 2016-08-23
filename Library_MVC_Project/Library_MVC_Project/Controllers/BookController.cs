using Library_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Library_MVC_Project.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            return View();

        }
        
        // InsertBook
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(BookModel obj)
        {
            if (ModelState.IsValid)
            {
                obj.insertbook();
                ViewBag.insertresult = "Inserted Book Sucessfully.....";
            }
            return View();
        }


        // UpdateBook
        public ActionResult Update(int? id)
        {
            BookModel obj = new BookModel();

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            LibraryDBEntities ldb = new LibraryDBEntities();
            BookTable pt = ldb.BookTables.Find(id);
            if (pt == null)
            {
                                 

                return HttpNotFound();
            }
            else
            {
                obj.BookID = pt.Id;
                obj.BookName = pt.BookName;
                obj.AuthorName = pt.AuthorName;
                
            }
            return View(pt);    
        }
        [HttpPost]
        public ActionResult Update(BookModel obj)
        {

            if (ModelState.IsValid)
            {
                obj.updatebook();
                ViewBag.updateresult = "Book Updated Sucessfully.....";
            }
            return View();
        }



        // DeleteBook
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(BookModel obj)
        {

            if (ModelState.IsValid)
            {
                obj.deletebook();
                ViewBag.deleteresult = "Book Delete Sucessfully.....";
            }
            return View();
        }


        public ActionResult display()
        {
            LibraryDBEntities ldb = new LibraryDBEntities();
            var str = ldb.BookTables.ToList();
            return View(str);
        }



    }
}