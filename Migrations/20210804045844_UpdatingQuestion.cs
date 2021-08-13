using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationSchool.Migrations
{
    public partial class UpdatingQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "QuestionName",
                table: "Questions",
                type: "nvarchar(250)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionName",
                table: "Questions");
        }
    }
}
