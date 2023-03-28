using Microsoft.EntityFrameworkCore.Migrations;

namespace SurveyApplication.Data.Migrations
{
    public partial class addDesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "PersonAnswers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "PersonAnswers");
        }
    }
}
