using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class CatAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatagoryTypeId",
                table: "PackageCatagories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatagoryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CatagoryTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Parcel" });

            migrationBuilder.InsertData(
                table: "CatagoryTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Food" });

            migrationBuilder.CreateIndex(
                name: "IX_PackageCatagories_CatagoryTypeId",
                table: "PackageCatagories",
                column: "CatagoryTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageCatagories_CatagoryTypes_CatagoryTypeId",
                table: "PackageCatagories",
                column: "CatagoryTypeId",
                principalTable: "CatagoryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageCatagories_CatagoryTypes_CatagoryTypeId",
                table: "PackageCatagories");

            migrationBuilder.DropTable(
                name: "CatagoryTypes");

            migrationBuilder.DropIndex(
                name: "IX_PackageCatagories_CatagoryTypeId",
                table: "PackageCatagories");

            migrationBuilder.DropColumn(
                name: "CatagoryTypeId",
                table: "PackageCatagories");
        }
    }
}
