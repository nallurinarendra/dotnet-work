using Library_MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_MVC_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel obj)
        {
            if (ModelState.IsValid)
            {
                int result = obj.Logincheck();

                if (result == 0)
                {
                    return Redirect("Admin/Index");                  
                    
                }
                else
                {
                    ViewBag.insertresult = "Login Not Sucessfully.....";
                }
            }

            return View(obj);
            
          
            
        }
    }
}