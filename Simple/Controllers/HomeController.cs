using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Simple.Models;

namespace Simple.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();
         
        
        public ActionResult Index()
        {
            
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
