using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineExaminationSchool.Models;
using OnlineExaminationSchool.ViewModels;
using System;

using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolTestProject.Controllers
{
    //Only Teacher Can Access This Controller
    //Guest comes in the absence of the respective teacher to create exam
    [Authorize(Roles ="Teacher,Guest")]
    public class TeacherController : Controller
    {
        //Injecting Dbcontext Class
        private readonly SchoolContext _schoolContext;

        //For files(Study Material)
        IHostingEnvironment _hostingEnvironment = null;
        
        public TeacherController(SchoolContext schoolContext,IHostingEnvironment hostingEnvironment)
        {
            _schoolContext = schoolContext;
            _hostingEnvironment = hostingEnvironment;
        }
        
        //Get Page For Creating Maths Assessment
        public IActionResult Index()
        {
           
           
                    
            return View();
        }

        //Creation Of Maths Exam
        [HttpPost]
        public IActionResult Index(QuestionOptionViewModel QuestionOption)
        {
            QuestionAndAnswer questionAndAnswer = new QuestionAndAnswer();
            questionAndAnswer.SubjectName = QuestionOption.SubjectName;
            questionAndAnswer.QuestionName = QuestionOption.QuestionName;
            questionAndAnswer.Option1 = QuestionOption.Option1;
            questionAndAnswer.Option2 = QuestionOption.Option2;
            questionAndAnswer.Option3 = QuestionOption.Option3;
            questionAndAnswer.Option4 = QuestionOption.Option4;
            questionAndAnswer.AnswerText = QuestionOption.AnswerText;
            _schoolContext.Add(questionAndAnswer);
            _schoolContext.SaveChanges();
            //Exam exam = new Exam();
            //Question question = new Question();
            //exam.QuestionName = QuestionOption.QuestionName;
            //question.CategoryId = QuestionOption.CategoryId;
            //question.IsActive = true;
            //question.IsMultiple = false;
            //_schoolContext.Add(question);

            //_schoolContext.SaveChanges();

            // int questionid = question.QuestionId;

            //foreach(var item in QuestionOption.ListOfOptions)
            // {
            // Exam exam = new Exam();
            //exam.Option1 = item;
            // option.QuestionId = questionid;
            // _schoolContext.Add(option);
            // _schoolContext.SaveChanges();

            // }//

            // Answer answer = new Answer();
            // answer.AnswerText =QuestionOption.AnswerText;
            // answer.QuestionId =questionid;
            // _schoolContext.Add(answer);
            //_schoolContext.SaveChanges();




            return View();
        }
        
        //Get Page For Creating English Assessment
        [HttpGet]
        public IActionResult English()
        {
            return View();
        }

        //Submission Of English Exam
        [HttpPost]
        public IActionResult English(QuestionOptionViewModel questionOptionViewModel)
        {
            EnglishQnA englishQnA = new EnglishQnA();
            englishQnA.SubjectName = questionOptionViewModel.SubjectName;
            englishQnA.QuestionName = questionOptionViewModel.QuestionName;
            englishQnA.Option1 = questionOptionViewModel.Option1;
            englishQnA.Option2 = questionOptionViewModel.Option2;
            englishQnA.Option3 = questionOptionViewModel.Option3;
            englishQnA.Option4 = questionOptionViewModel.Option4;
            englishQnA.AnswerText = questionOptionViewModel.AnswerText;
            _schoolContext.Add(englishQnA);
            _schoolContext.SaveChanges();
            return View();
        }

       //Get Page For Science Assessment Creation
        [HttpGet]
        public IActionResult Science()
        {
            return View();

        }

        //Submitting The Questions And Answers 
        [HttpPost]
        public IActionResult Science(QuestionOptionViewModel questionOptionViewModel)
        {
            ScienceExam socialExam = new ScienceExam();
            socialExam.SubjectName = questionOptionViewModel.SubjectName;
            socialExam.QuestionName = questionOptionViewModel.QuestionName;
            socialExam.Option1 = questionOptionViewModel.Option1;
            socialExam.Option2 = questionOptionViewModel.Option2;
            socialExam.Option3 = questionOptionViewModel.Option3;
            socialExam.Option4 = questionOptionViewModel.Option4;
            socialExam.AnswerText = questionOptionViewModel.AnswerText;
            _schoolContext.Add(socialExam);
            _schoolContext.SaveChanges();
            return View();
        }

        //Get Page For Social Assessment Creation
        [HttpGet]
        public IActionResult Social()
        {
            return View();
        }

        //Submitting Social Assessment details
        [HttpPost]
        public IActionResult Social(QuestionOptionViewModel questionOptionViewModel)
        {
            SocialExam socialExam = new SocialExam();
            socialExam.SubjectName = questionOptionViewModel.SubjectName;
            socialExam.QuestionName = questionOptionViewModel.QuestionName;
            socialExam.Option1 = questionOptionViewModel.Option1;
            socialExam.Option2 = questionOptionViewModel.Option2;
            socialExam.Option3 = questionOptionViewModel.Option3;
            socialExam.Option4 = questionOptionViewModel.Option4;
            socialExam.AnswerText = questionOptionViewModel.AnswerText;
            _schoolContext.Add(socialExam);
            _schoolContext.SaveChanges();


            return View();
        }



        //Get Study Material Upload Page 
        [HttpGet]
        public IActionResult File(string filename = "")
        {
            StudyMaterial fileObj = new StudyMaterial();
            fileObj.Name = filename;



            string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
            int nId = 1;



            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new StudyMaterial()
                {
                    FileId = nId++,
                    Name = Path.GetFileName(pdfPath),
                    path = pdfPath
                });
            }
            return View(fileObj);
        }


        //Posting The Study Material
        [HttpPost]



        public IActionResult File(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            return File();
        }

        //Giving Access To Student To Get The Study Material

        [Authorize(Roles = "Student")]
        public IActionResult PDFViewerNewTab(string fileName)
        {
            string path = _hostingEnvironment.WebRootPath + "\\files\\" + fileName;
            return File(System.IO.File.ReadAllBytes(path), "application/pdf");
        }

        //Giving Access To Student To Get The Study Material
        [Authorize(Roles ="Student")]
        public IActionResult StudentMaterial(string filename)
        {
            return File();
        }

        //Navigation Page For Teacher
        public IActionResult TeacherIndex()
        {
            return View();

        }


        
        

     
        }





    }

