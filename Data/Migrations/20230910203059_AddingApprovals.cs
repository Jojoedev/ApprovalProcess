using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class AddingApprovals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FinanceDirector",
                table: "Requests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LineManager",
                table: "Requests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagingDirector",
                table: "Requests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinanceDirector",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "LineManager",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "ManagingDirector",
                table: "Requests");
        }
    }
}
