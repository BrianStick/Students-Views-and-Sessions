using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views_and_Sessions.Models;

namespace Views_and_Sessions.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Brian", "Stickne", "???", 28)
            };
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