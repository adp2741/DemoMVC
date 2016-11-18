using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";
            ViewBag.MoreInfo = "This is a test from Andrew.";
            return View();
        }

        [HttpPost]
        public ActionResult About(string userData)
        {
            ViewBag.Title = "Congratulations!";
            ViewBag.Message = userData;
            ViewBag.MoreInfo = "Nice job, you posted an item!";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}