using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.Models
{
    public class DbUser
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(250)")]
        public string UserName { get; set; }
        [Column(TypeName = "datetime")]

        public DateTime LoginTime { get; set; }
        [Column(TypeName = "int")]

        public int CategoryId { get; set; }
    }
}
