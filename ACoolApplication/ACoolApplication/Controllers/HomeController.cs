using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACoolApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My cool aplication 1.0.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tudor contact page.";

            return View();
        }
    }
}