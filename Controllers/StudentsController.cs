using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmHelperAnnotation.Models;

namespace HtmHelperAnnotation.Controllers
{
    public class StudentsController : Controller
    {
        public ActionResult Create()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student aStudent)
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }


        [HttpPost]
        public ActionResult Registration(Student aStudent)
        {
            if (ModelState.IsValid)
            {
                //DB Code
            }
            ViewBag.Departments = GetDepartments();
            return View();
        }

        private List<Department> GetDepartments()
        {
            return new List<Department>()
            {
                new Department(){Id = 1, Name = "Computer Science & Engineering", Code = "CSE"},
                new Department(){Id = 2, Name = "Electrical and Electronics & Engineering", Code = "EEE"},
                new Department(){Id = 3, Name = "Physics", Code = "Phy"},
                new Department(){Id = 4, Name = "Chemistry", Code = "CHM"}
            };
        }

        private List<Student> GetAllStudents()
        {
            return new List<Student>()
            {
                new Student(){Id = 1,Name = "Tuhin"},
                new Student(){Id = 2, Name = "shamim"},
                new Student(){Id = 3, Name = "Amin"},
                new Student(){Id = 4, Name = "Amin"},
                new Student(){Id = 5, Name = "Amin"}
            };
        }

        private List<Course> GetAllCourses()
        {
            return new List<Course>()
            {
                new Course(){Id = 1, Title = "DataBase", Credits = 3.00},
                new Course(){Id = 2, Title = "Algorithm", Credits = 3.00},
                new Course(){Id = 3, Title = "C Shrpe", Credits = 3.00},
                new Course(){Id = 4, Title = "C ++", Credits = 3.00},
                new Course(){Id = 5, Title = "Java", Credits = 3.00}
            };
        }

        [HttpGet]
        public ActionResult EnrollCourse()
        {
            ViewBag.Students = GetAllStudents();
            ViewBag.Courses = GetAllCourses();
            return View();
        }
        [HttpPost]
        public ActionResult EnrollCourse(StudentCourse aStudentCourse)
        {
            ViewBag.Students = GetAllStudents();
            ViewBag.Courses = GetAllCourses();
            return View();
        }
        

    }
}