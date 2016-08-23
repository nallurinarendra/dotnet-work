using MVC_MatheMaticalApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_MatheMaticalApplication.Controllers
{
    public class MatheMaticalController : Controller
    {
        // GET: MatheMatical
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]       
        public ActionResult Index(MatheMaticalModel obj)
        {
           
            if (ModelState.IsValid)
            {
                ViewData["Add"] = obj.Addition();
                ViewData["Sub"] = obj.substraction();
                ViewData["Mul"] = obj.Multiplication();
                ViewData["Div"] = obj.Division();
                ViewData["Rem"] = obj.Remainder();
               
            }
            return View();
        }
    }
}