using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class NullablePackageCatAndLoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Locations_LocationToId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_PackageCatagories_PackageCatagoryId",
                table: "Packages");

            migrationBuilder.AlterColumn<int>(
                name: "PackageCatagoryId",
                table: "Packages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LocationToId",
                table: "Packages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Locations_LocationToId",
                table: "Packages",
                column: "LocationToId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_PackageCatagories_PackageCatagoryId",
                table: "Packages",
                column: "PackageCatagoryId",
                principalTable: "PackageCatagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Locations_LocationToId",
                table: "Packages");

            migrationBuilder.DropForeignKey(
                name: "FK_Packages_PackageCatagories_PackageCatagoryId",
                table: "Packages");

            migrationBuilder.AlterColumn<int>(
                name: "PackageCatagoryId",
                table: "Packages",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocationToId",
                table: "Packages",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Locations_LocationToId",
                table: "Packages",
                column: "LocationToId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_PackageCatagories_PackageCatagoryId",
                table: "Packages",
                column: "PackageCatagoryId",
                principalTable: "PackageCatagories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
