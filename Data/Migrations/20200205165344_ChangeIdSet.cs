using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductionLiteWebApp.Migrations
{
    public partial class ChangeIdSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WellId",
                table: "Wells",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SaleId",
                table: "Sales",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductionId",
                table: "Productions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberId",
                table: "PhoneNumber",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Companies",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Wells",
                newName: "WellId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Sales",
                newName: "SaleId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Productions",
                newName: "ProductionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PhoneNumber",
                newName: "PhoneNumberId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Companies",
                newName: "CompanyId");
        }
    }
}
