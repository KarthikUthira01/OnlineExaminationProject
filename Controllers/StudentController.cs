using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineExaminationSchool.Models;
using OnlineExaminationSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolTestProject.Controllers
{
    [Authorize(Roles ="Student,Teacher")]
    public class StudentController : Controller
    {
        private readonly SchoolContext _schoolContext;
        public StudentController(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult EnglishExam()
        {
            var results = _schoolContext.EnglishQnAs.ToList();
            return View(results);
        }
        public IActionResult MathsExam()
        {
            var results = _schoolContext.QuestionAndAnswers.ToList();
            return View(results);
        }

        public IActionResult ScienceExam()
        {
            var results = _schoolContext.ScienceExams.ToList();
            return View(results);
        }
        public IActionResult SocialExam()
        {
            var results = _schoolContext.SocialExams.ToList();
            return View(results);
            
        }
        public IActionResult TestName()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MarkSubmission()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MarkSubmission(ResultViewModel resultViewModel)
        {
            ResultFSUnitTest resultFSUnitTest = new ResultFSUnitTest();
            resultFSUnitTest.Name = resultViewModel.Name;
            resultFSUnitTest.Subject = resultViewModel.Subject;
            resultFSUnitTest.Marks = resultViewModel.Marks;
            return View();
        }
    }
}
