using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class UpdatingVendorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Vendors");

            migrationBuilder.AlterColumn<string>(
                name: "VendorName",
                table: "Vendors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Vendors",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "Vendors",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Vendors",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Vendors");

            migrationBuilder.AlterColumn<string>(
                name: "VendorName",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Vendors",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
