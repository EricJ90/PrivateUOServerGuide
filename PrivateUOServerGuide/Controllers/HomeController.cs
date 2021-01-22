using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrivateUOServerGuide.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Want your own private UO Server to experiment on?";
            return View();
        }

        public ActionResult Step1()
        {
            ViewBag.Message = "Step 1";

            return View();
        }

        public ActionResult Step2()
        {
            ViewBag.Message = "Step 2";
            return View();
        }

        public ActionResult Step3()
        {
            ViewBag.Message = "Step 3";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}