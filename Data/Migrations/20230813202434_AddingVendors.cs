using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class AddingVendors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Requests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_VendorId",
                table: "Requests",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Vendors_VendorId",
                table: "Requests",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Vendors_VendorId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_VendorId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Requests");
        }
    }
}
