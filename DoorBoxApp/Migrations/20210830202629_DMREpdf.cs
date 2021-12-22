using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class DMREpdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "Packages",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_VendorId",
                table: "Packages",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Packages_Vendors_VendorId",
                table: "Packages",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Packages_Vendors_VendorId",
                table: "Packages");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Packages_VendorId",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Packages");
        }
    }
}
