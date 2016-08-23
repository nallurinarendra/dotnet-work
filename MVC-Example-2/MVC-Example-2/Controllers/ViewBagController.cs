﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Example_2.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
        public ActionResult Index()
        {
            List<string> Student = new List<string>();
            Student.Add("Raju");
            Student.Add("Prakash");
            Student.Add("Rani");

            ViewBag.StudentsList = Student;
                        
            return View();
        }
    }
}