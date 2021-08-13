using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.Models
{
    public class StudyMaterial
    {
        public int FileId { get; set; } = 0;



        public string Name { get; set; } = "";



        public string path { get; set; } = "";



        public List<StudyMaterial> Files { get; set; } = new List<StudyMaterial>();
    }
}
