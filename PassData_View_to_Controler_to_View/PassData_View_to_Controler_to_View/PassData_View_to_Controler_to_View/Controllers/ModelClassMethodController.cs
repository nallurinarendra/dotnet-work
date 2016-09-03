using PassData_View_to_Controler_to_View.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassData_View_to_Controler_to_View.Controllers
{
    public class ModelClassMethodController : Controller
    {
        // GET: ModelClassMethod
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ModelMethodClass obj)
        {
            string txtfirstname = obj.firstname;
            string txtlastname = obj.lastname;
            ViewBag.Name = txtfirstname + txtlastname;
            return View();
        }
    }
}