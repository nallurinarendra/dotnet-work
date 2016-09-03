using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDataVieBagTempDataExample.Controllers
{
    public class ViewDataExampleController : Controller
    {
        // GET: ViewDataExample
        public ActionResult Index()
        {
            ViewData["MyName"] = "Abhi";
            return View();
        }
    }
}