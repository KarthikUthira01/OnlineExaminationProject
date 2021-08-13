using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationSchool.Models
{
    public class SchoolContext:IdentityDbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        
        
        
        public DbSet<DbUser> DbUsers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<QuestionAndAnswer> QuestionAndAnswers { get; set; }
        public DbSet<ScienceExam> ScienceExams { get; set; }
        public DbSet<EnglishQnA> EnglishQnAs { get; set; }
        public DbSet<SocialExam> SocialExams { get; set; }

        public DbSet<ResultFSUnitTest> resultFSUnitTests { get; set; }

    }
}
