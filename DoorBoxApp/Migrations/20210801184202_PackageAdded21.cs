using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class PackageAdded21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OTP",
                table: "Packages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OTP",
                table: "Packages");
        }
    }
}
