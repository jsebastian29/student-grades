using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentGradesMVC.Controllers
{
    //https://www.c-sharpcorner.com/UploadFile/8a67c0/Asp-Net-mvc-code-first-approach-with-repository-pattern/
    //https://www.youtube.com/watch?v=jYvkMv7LzCw
    public class StudentGradeController : Controller
    {
        private IStudentGradeRepository<StudentGrade> _repository = null;
        public StudentGradeController()
        {
            this._repository = new StudentGradeRepository<StudentGrade>();
        }
        public ActionResult Index()
        {

            var lstStudentGrades = _repository.GetAll();
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