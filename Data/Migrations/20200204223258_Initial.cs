using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductionLiteWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CtratedTime",
                table: "Wells",
                newName: "CreatedTime");

            migrationBuilder.RenameColumn(
                name: "CtratedTime",
                table: "Users",
                newName: "CreatedTime");

            migrationBuilder.RenameColumn(
                name: "CtratedTime",
                table: "Sales",
                newName: "CreatedTime");

            migrationBuilder.RenameColumn(
                name: "CtratedTime",
                table: "Productions",
                newName: "CreatedTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Wells",
                newName: "CtratedTime");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Users",
                newName: "CtratedTime");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Sales",
                newName: "CtratedTime");

            migrationBuilder.RenameColumn(
                name: "CreatedTime",
                table: "Productions",
                newName: "CtratedTime");
        }
    }
}
