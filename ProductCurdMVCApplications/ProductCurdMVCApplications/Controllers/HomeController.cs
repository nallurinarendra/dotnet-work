using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProductCurdMVCApplications.Controllers
{
    public class HomeController : Controller
    {
        ProductsDBEntities db = new ProductsDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var str = db.ProductsTables.ToList();
            return View(str);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "pno,pname,rate")] ProductsTable pt)
        {
            if (ModelState.IsValid)
            {
                db.ProductsTables.Add(pt);                
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pt);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsTable pt = db.ProductsTables.Find(id);            
            if (pt == null)
            {

                return HttpNotFound();
            }
            return View(pt);            
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "pno,pname,rate")] ProductsTable pt)
        {
            if (ModelState.IsValid)
            {

                db.Entry(pt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pt);
        }


        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsTable pt = db.ProductsTables.Find(id);
            if (pt == null)
            {

                return HttpNotFound();
            }
            return View(pt);  
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsTable pt = db.ProductsTables.Find(id);
            if (pt == null)
            {

                return HttpNotFound();
            }
            return View(pt);  
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductsTable pt = db.ProductsTables.Find(id);
            db.ProductsTables.Remove(pt);            
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}