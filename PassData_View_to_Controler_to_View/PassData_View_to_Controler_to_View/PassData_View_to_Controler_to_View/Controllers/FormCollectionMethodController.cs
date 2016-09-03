using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassData_View_to_Controler_to_View.Controllers
{
    public class FormCollectionMethodController : Controller
    {
        // GET: FormCollectionMethod
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            string txtfirstname = form["txtfirstname"].ToString();
            string txtlastname = form["txtlastname"].ToString();
            ViewBag.Name = txtfirstname + txtlastname;
            return View();
        }
    }
}