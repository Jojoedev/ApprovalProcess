using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class AddedDept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentalList",
                table: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Departments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentalList",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
