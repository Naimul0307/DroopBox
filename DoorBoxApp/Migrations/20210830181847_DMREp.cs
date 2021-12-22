using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class DMREp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MerchantId",
                table: "Packages",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Packages_MerchantId",
                table: "Packages",
                column: "MerchantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Merchants_MerchantId",
                table: "Packages",
                column: "MerchantId",
                principalTable: "Merchants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Merchants_MerchantId",
                table: "Packages");

            migrationBuilder.DropIndex(
                name: "IX_Packages_MerchantId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "Packages");
        }
    }
}
