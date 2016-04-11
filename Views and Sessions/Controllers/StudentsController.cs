using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views_and_Sessions.Models;

namespace Views_and_Sessions.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Brian", "Stickney", "???", 28)
            };

            return View(students);
        }
    }
}