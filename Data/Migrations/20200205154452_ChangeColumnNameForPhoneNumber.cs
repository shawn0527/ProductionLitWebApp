using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductionLiteWebApp.Migrations
{
    public partial class ChangeColumnNameForPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkPhoneNumbur",
                table: "PhoneNumber",
                newName: "WorkPhoneNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkPhoneNumber",
                table: "PhoneNumber",
                newName: "WorkPhoneNumbur");
        }
    }
}
