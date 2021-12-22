using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class CHange23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SubLocations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PackageTypeId",
                table: "Packages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubLocationId",
                table: "Packages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageTypeId",
                table: "Packages",
                column: "PackageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_SubLocationId",
                table: "Packages",
                column: "SubLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_PackageTypes_PackageTypeId",
                table: "Packages",
                column: "PackageTypeId",
                principalTable: "PackageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_SubLocations_SubLocationId",
                table: "Packages",
                column: "SubLocationId",
                principalTable: "SubLocations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_PackageTypes_PackageTypeId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_SubLocations_SubLocationId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_PackageTypeId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_SubLocationId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "SubLocations");

            migrationBuilder.DropColumn(
                name: "PackageTypeId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "SubLocationId",
                table: "Packages");
        }
    }
}
