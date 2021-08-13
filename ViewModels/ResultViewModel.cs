using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.ViewModels
{
    public class ResultViewModel
    {
        [Required]
        [Display(Name ="Enter Your Name Here")]
        public string Name { get; set; }
        [Required]
        [Display(Name ="Enter Your Mark")]
        public int Marks { get; set; }
        [Required]
        [Display(Name ="Enter the Subject name")]
        public string Subject { get; set; }
    }
}
