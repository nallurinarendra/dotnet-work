using Employee_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModelClass obj)
        {
            string uname = obj.username;
            string pass = obj.password;

            if (uname == "admin" && pass == "admin")
            {              
                Response.Redirect("~/Employee_tbl/Index");
              
            }
            else
            {
                ViewBag.result = "Invalid LoginDetails.....";
            }

            return View();
        }
        
        
    }
}