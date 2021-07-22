using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NETCore.Migrations
{
    public partial class RemovedLanguagesAndGenderColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Languages",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Languages",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
