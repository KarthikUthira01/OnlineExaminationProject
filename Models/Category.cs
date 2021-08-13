using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Column(TypeName = "nvarchar(250)")]
        public string CategoryName { get; set; }
    }
}
