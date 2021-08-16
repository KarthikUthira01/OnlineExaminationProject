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
    //Student as well as Teacher Can Access This Controller(Teacher To Monitor Student's Activities) 
    [Authorize(Roles ="Student,Teacher")]
    public class StudentController : Controller
    {
        //injecting dbcontext class

        private readonly SchoolContext _schoolContext;
        public StudentController(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }
        //Navigation Page For Students
        public IActionResult Index()
        {

            return View();
        }
        //Goes to Take English Exam
        public IActionResult EnglishExam()
        {
            var results = _schoolContext.EnglishQnAs.ToList();
            return View(results);
        }
        //Goes to Take Maths Exam

        public IActionResult MathsExam()
        {
            var results = _schoolContext.QuestionAndAnswers.ToList();
            return View(results);
        }
        //Goes to Take Science Exam

        public IActionResult ScienceExam()
        {
            var results = _schoolContext.ScienceExams.ToList();
            return View(results);
        }
        //Goes to Take Social Exam

        public IActionResult SocialExam()
        {
            var results = _schoolContext.SocialExams.ToList();
            return View(results);
            
        }

        //Navigation Page For Test 
        public IActionResult TestName()
        {
            return View();
        }

        //Manual Mark Submission By Students(Get Page)
        [HttpGet]
        public IActionResult MarkSubmission()
        {
            return View();
        }

        //Submission Of Marks
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
