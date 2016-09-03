using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassData_View_to_Controler_to_View.Controllers
{
    public class RequestMethodController : Controller
    {
        // GET: RequestMethod
        [HttpGet]
        public ActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult Index_Post()
        {
            string firstname = Request["txtfirstname"].ToString();
            string lastname = Request["txtlastname"].ToString();
            ViewBag.Name = firstname + lastname ;
            return View();
            
        }
    }
}