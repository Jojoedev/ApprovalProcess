using Microsoft.EntityFrameworkCore.Migrations;

namespace ApprovalProcess.Data.Migrations
{
    public partial class AddedDeptModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequesterDepartment",
                table: "Requests");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Requests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentalList = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Requests_DepartmentId",
                table: "Requests",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Departments_DepartmentId",
                table: "Requests",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Departments_DepartmentId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Requests_DepartmentId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Requests");

            migrationBuilder.AddColumn<string>(
                name: "RequesterDepartment",
                table: "Requests",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
