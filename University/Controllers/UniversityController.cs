using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using University.Models;
using UniversityMVC.Models;

namespace University.Controllers
{
    public class UniversityController : Controller
    {

        private DBContext dbContext = new DBContext();
        public UniversityController()
        {
        }

        public IActionResult Index()
        {
            ViewData["students"] = dbContext.students;
            return View();
        }

        public IActionResult Create(Student student)
        {
            if (student != null)
            {
                dbContext.students.Add(student);
                ViewData["students"] = dbContext.students;
                return View("AllStudentsList");
            }
            return View();
        }
        public IActionResult AllStudentsList()
        {
            ViewData["students"] = dbContext.students;
            return View();

        }

        [HttpPut]
        public IActionResult Update(int id)
        {
            ViewData["students"] = dbContext.students;
            Student stud = dbContext.students.Where(x => x.StudentID == id).FirstOrDefault();
            return View(stud);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {
            foreach (var tempStudent in dbContext.students)
            {
                if (tempStudent.StudentID == student.StudentID)
                {
                    tempStudent.StudentID = student.StudentID;
                    tempStudent.StudentName = student.StudentName;
                    tempStudent.sectiondID = student.sectiondID;
                    tempStudent.sectionName = student.sectionName;
                    tempStudent.StudentAge = student.StudentAge;
                    tempStudent.UniversityId = student.UniversityId;
                    tempStudent.UniversityName = student.UniversityName;

                }
            }
            ViewData["students"] = dbContext.students;
            return RedirectToAction("AllStudentsList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
