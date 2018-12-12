using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class DefaultController : Controller
    {
        //// GET: Default
        //public ActionResult Index()
        //{
        //    return View();
        //}

        

        public string Index(string id)
        {
            return "This is default controller invoked and ID : " + id;
        }
    }
}