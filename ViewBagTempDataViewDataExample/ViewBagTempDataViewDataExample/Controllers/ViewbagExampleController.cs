using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBagTempDataViewDataExample.Controllers
{
    public class ViewbagExampleController : Controller
    {
        // GET: ViewbagExample
        public ActionResult Index()
        {
            string MyCompany = "SaiberSys";

            // ViewBag.Viewbagname

            ViewBag.company = MyCompany;

            return View();
        }
    }
}