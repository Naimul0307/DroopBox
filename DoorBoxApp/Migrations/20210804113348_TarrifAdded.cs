using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class TarrifAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarrifs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PackageCatagoryId = table.Column<int>(nullable: false),
                    LocationFromId = table.Column<int>(nullable: false),
                    LocationToId = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    FixedAmountFirstKG = table.Column<double>(nullable: false),
                    IncrementPerKG = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarrifs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarrifs_Locations_LocationFromId",
                        column: x => x.LocationFromId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tarrifs_Locations_LocationToId",
                        column: x => x.LocationToId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tarrifs_PackageCatagories_PackageCatagoryId",
                        column: x => x.PackageCatagoryId,
                        principalTable: "PackageCatagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tarrifs_LocationFromId",
                table: "Tarrifs",
                column: "LocationFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarrifs_LocationToId",
                table: "Tarrifs",
                column: "LocationToId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarrifs_PackageCatagoryId",
                table: "Tarrifs",
                column: "PackageCatagoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarrifs");
        }
    }
}
