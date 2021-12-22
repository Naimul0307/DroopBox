using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class Chages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DeliveryRate",
                table: "DeliveryMans",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PickUpRate",
                table: "DeliveryMans",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Salary",
                table: "DeliveryMans",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MerchantTarrifs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PackageCatagoryId = table.Column<int>(nullable: false),
                    MerchantId = table.Column<int>(nullable: false),
                    LocationFromId = table.Column<int>(nullable: false),
                    LocationToId = table.Column<int>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    FixedAmountFirstKG = table.Column<double>(nullable: false),
                    IncrementPerKG = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchantTarrifs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MerchantTarrifs_Locations_LocationFromId",
                        column: x => x.LocationFromId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MerchantTarrifs_Locations_LocationToId",
                        column: x => x.LocationToId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MerchantTarrifs_Merchants_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MerchantTarrifs_PackageCatagories_PackageCatagoryId",
                        column: x => x.PackageCatagoryId,
                        principalTable: "PackageCatagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PackageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubLocations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MerchantTarrifs_LocationFromId",
                table: "MerchantTarrifs",
                column: "LocationFromId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantTarrifs_LocationToId",
                table: "MerchantTarrifs",
                column: "LocationToId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantTarrifs_MerchantId",
                table: "MerchantTarrifs",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchantTarrifs_PackageCatagoryId",
                table: "MerchantTarrifs",
                column: "PackageCatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubLocations_LocationId",
                table: "SubLocations",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerchantTarrifs");

            migrationBuilder.DropTable(
                name: "PackageTypes");

            migrationBuilder.DropTable(
                name: "SubLocations");

            migrationBuilder.DropColumn(
                name: "DeliveryRate",
                table: "DeliveryMans");

            migrationBuilder.DropColumn(
                name: "PickUpRate",
                table: "DeliveryMans");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "DeliveryMans");

            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "AspNetUsers");
        }
    }
}
