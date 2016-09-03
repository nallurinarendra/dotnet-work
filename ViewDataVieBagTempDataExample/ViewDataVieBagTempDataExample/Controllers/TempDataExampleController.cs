using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewDataVieBagTempDataExample.Controllers
{
    public class TempDataExampleController : Controller
    {
        // GET: TempDataExample
        public ActionResult Index()
        {
            TempData["MyName"] = "Abhi";
            return View();
        }
    }
}