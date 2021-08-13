using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationSchool.Migrations
{
    public partial class AddingExamTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionName = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Option1 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option2 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option3 = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Option4 = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
