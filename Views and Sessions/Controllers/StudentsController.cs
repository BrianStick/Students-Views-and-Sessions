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
                new Student(1, "Brian", "Stickney", "???", 28),
                new Student(2,"Matthew","Botley","male",20),
            };

            return View(students);
            
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student newStudent)
        {
            if (ModelState.IsValid)
            {
                var currentStudents = (List<Student>)Session["students"];
                if (currentStudents == null)
                {
                    currentStudents = new List<Student>();
                }
                currentStudents.Add(newStudent);

                Session["students"] = currentStudents;

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //GET EDIT
        public ActionResult Edit(int id)
        {
            List<Student> students = new List<Student>();
            var std = students.FirstOrDefault(s => s.Id == s.Id);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            return View();

        }
}