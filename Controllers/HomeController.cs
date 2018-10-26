using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TwoRandomTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random random = new Random();
            int num1 = random.Next(100);
            int num2 = random.Next(100);
            ViewBag.num1 = num1;
            ViewBag.num2 = num2;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}