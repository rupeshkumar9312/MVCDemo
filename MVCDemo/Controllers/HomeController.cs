using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
           // return $"Id = {id}";
            return "Hello Welcome to ASP.net MVC"; 

        }

        public string Logout()
        {
            return "You are logged out from the session";
        }


        public ActionResult Countries()
        {
            //ViewBag.Countries =  new List<string>()
            //{
            //    "India",
            //    "Pakisan",
            //    "Australia",
            //    "Bangladesh"
            //};
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "Pakisan",
                "Australia",
                "Bangladesh"
            };
            return View();
        }
    }
}