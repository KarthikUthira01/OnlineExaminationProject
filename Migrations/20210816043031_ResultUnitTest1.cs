using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineExaminationSchool.Migrations
{
    public partial class ResultUnitTest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_resultFSUnitTests",
                table: "resultFSUnitTests");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "resultFSUnitTests",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "resultFSUnitTests",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_resultFSUnitTests",
                table: "resultFSUnitTests",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_resultFSUnitTests",
                table: "resultFSUnitTests");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "resultFSUnitTests");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "resultFSUnitTests",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_resultFSUnitTests",
                table: "resultFSUnitTests",
                column: "Name");
        }
    }
}
