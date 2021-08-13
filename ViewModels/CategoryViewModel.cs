using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.ViewModels
{
    public class CategoryViewModel
    {
        
        
        public int CategoryId { get; set; }
        [Required]
        public string QuestionName { get; set; }
        public int CategoryName { get; set; }
        public int OptionName { get; set; }

        public IEnumerable<SelectListItem> ListOfCategory { get; set; }
    }
}
