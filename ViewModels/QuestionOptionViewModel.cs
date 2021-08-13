using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.ViewModels
{
    public class QuestionOptionViewModel
    {
        public int QId { get; set; }
        public string SubjectName { get; set; }
        [Required]
        public string QuestionName { get; set; }
        [Required]
        public string Option1 { get; set; }
        [Required]

        public string Option2 { get; set; }
        [Required]

        public string Option3 { get; set; }
        [Required]

        public string Option4 { get; set; }
        [Required]

        public string AnswerText { get; set; }

       
        
       

     
    }
}
