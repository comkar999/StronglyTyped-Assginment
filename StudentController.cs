using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StronglyTypedAssignment.Models;

namespace StronglyTypedAssignment.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student s = new Student() { Name = "Mitchell", Address = "Sydney" };
            return View(s);
        }
    }
}