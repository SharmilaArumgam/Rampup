using Mvc_Start.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Start.Controllers
{
    public class StudentController : Controller
    {
        // GET: ViewBag  
        public ActionResult Index()
        {
            List<Student> students = new List<Student>
            {
            new Student{Name="Sneha",Email="Sneha@example.com",Age=22},
            new Student{Name="Cj",Email="Cj@example.com",Age=21},
            new Student{Name="Sharmi",Email="Sharmi@example.com",Age=21},
            new Student{Name="Raina",Email="Raina@example.com",Age=22},
            };
            // ViewData["students"] = students;
            return View(students);
        }
    }
}