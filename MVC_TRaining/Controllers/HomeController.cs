using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_TRaining.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public string Default()
        {
            return "Pass the controller/index name in URL?";
        }
        public string Index()
        {
            ViewBag.passSomeData = "Hello data came fromm controller to view ";
            //returning just string 
            return "Hi There!!!!!! Returning just string :)";
            //return View();
        }
    }
}