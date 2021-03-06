using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.ViewModels
{
    public class QuestionAnswerViewModel
    {
        public int OptionId { get; set; }
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public List<QuizOption> ListOfQuizOption { get; set; }
    }
    public class QuizOption
    {
        public int OptionId { get; set; }
        public string OptionName { get; set; }

    }
}
