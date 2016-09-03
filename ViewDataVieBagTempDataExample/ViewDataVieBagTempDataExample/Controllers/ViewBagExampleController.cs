using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDataVieBagTempDataExample.Controllers
{
    public class ViewBagExampleController : Controller
    {
        // GET: ViewBagExample
        public ActionResult Index()
        {
            ViewBag.Myname = "Abhi";
            return View();
        }
    }
}