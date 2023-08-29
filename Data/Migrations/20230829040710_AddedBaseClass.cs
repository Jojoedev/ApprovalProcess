using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class AddedBaseClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Statuses_FirstApproverId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Statuses");

            migrationBuilder.CreateTable(
                name: "FirstApprovers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstApprovers", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_FirstApprovers_FirstApproverId",
                table: "Requests",
                column: "FirstApproverId",
                principalTable: "FirstApprovers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_FirstApprovers_FirstApproverId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "FirstApprovers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Statuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Statuses_FirstApproverId",
                table: "Requests",
                column: "FirstApproverId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
