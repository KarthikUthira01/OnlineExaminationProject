using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.Models
{
    public class Exam
    {
        [Key]
        public int ExamId { get; set; }
        [Column(TypeName ="nvarchar(500)")]
        public string QuestionName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Option1 { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Option2 { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Option3 { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string Option4 { get; set; }
        [Column(TypeName = "nvarchar(250)")]

        public string CorrectAnswer { get; set; }



    }
}
