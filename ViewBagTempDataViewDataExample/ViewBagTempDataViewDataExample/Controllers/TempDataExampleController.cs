using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBagTempDataViewDataExample.Controllers
{
    public class TempDataExampleController : Controller
    {
        // GET: TempDataExample
        public ActionResult Index()
        {
            string MyCompany = "SaiberSys";

            // TempData["TempDataname"]

            TempData["company"] = MyCompany;
            

            return View();
        }
    }
}