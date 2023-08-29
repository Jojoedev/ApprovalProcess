using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class FirstApprover : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Statuses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FirstApproverId",
                table: "Requests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Requests_FirstApproverId",
                table: "Requests",
                column: "FirstApproverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Statuses_FirstApproverId",
                table: "Requests",
                column: "FirstApproverId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Statuses_FirstApproverId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_FirstApproverId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Statuses");

            migrationBuilder.DropColumn(
                name: "FirstApproverId",
                table: "Requests");
        }
    }
}
