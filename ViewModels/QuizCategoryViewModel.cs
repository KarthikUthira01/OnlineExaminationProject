using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.ViewModels
{
    public class QuizCategoryViewModel
    {
        [Display(Name ="Category")]
        [Required(ErrorMessage ="Category is required")]
        public int CategoryId { get; set; }
        [Display(Name = "Candidate")]
        [Required(ErrorMessage = "Candidate is required")]
        public string CandidateName { get; set; }
        public IEnumerable<SelectListItem> ListOfCategory { get; set; }

    }
}
