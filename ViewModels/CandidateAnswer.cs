using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.ViewModels
{
    public class CandidateAnswer
    {
        public int QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool IsLast { get; set; }
    }
}
