using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationSchool.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnglishQnAs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    QuestionName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option2 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option3 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option4 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    AnswerText = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnglishQnAs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScienceExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    QuestionName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option2 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option3 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option4 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    AnswerText = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScienceExams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    QuestionName = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option2 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option3 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option4 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    AnswerText = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialExams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnglishQnAs");

            migrationBuilder.DropTable(
                name: "ScienceExams");

            migrationBuilder.DropTable(
                name: "SocialExams");
        }
    }
}
