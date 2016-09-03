using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBagTempDataViewDataExample.Controllers
{
    public class ViewDataExampleController : Controller
    {
        // GET: ViewDataExample
        public ActionResult Index()
        {
            string MyCompany = "SaiberSys";

            // ViewData["viewdataname"]

            ViewData["company"] = MyCompany;

            return View();
        }
    }
}