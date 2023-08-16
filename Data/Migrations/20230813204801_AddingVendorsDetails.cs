using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class AddingVendorsDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Vendors",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Vendors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Vendors");
        }
    }
}
