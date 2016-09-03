using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBagViewDataTempDataModel2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewBagModel()
        {
             List<string> Student = new List<string>();
             Student.Add("Bijaya Gautam");
             Student.Add("Rikesh Tuladhar");
             Student.Add("Swathi");
             Student.Add("Zain");

             ViewBag.MyStudents = Student;

            return View();
        }

        public ActionResult ViewDataModel()
        {
            List<string> Student = new List<string>();
            Student.Add("Bijaya Gautam");
            Student.Add("Rikesh Tuladhar");
            Student.Add("Swathi");
            Student.Add("Zain");

            ViewData["MyStudents"] = Student;

            return View();
        }

        public ActionResult TempDataModel()
        {
            List<string> Student = new List<string>();
            Student.Add("Bijaya Gautam");
            Student.Add("Rikesh Tuladhar");
            Student.Add("Swathi");
            Student.Add("Zain");

            TempData["MyStudents"] = Student;

            return View();
        }
    }
}