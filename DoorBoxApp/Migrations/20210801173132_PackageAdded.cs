using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class PackageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PickupAddress",
                table: "PickUpRequests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PackageCatagories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageCatagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PickUpRequestId = table.Column<int>(nullable: false),
                    PackageCatagoryId = table.Column<int>(nullable: false),
                    TrackingNumber = table.Column<string>(nullable: true),
                    LocationToId = table.Column<int>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Weight = table.Column<double>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ProductPrice = table.Column<double>(nullable: true),
                    Dimension = table.Column<string>(nullable: true),
                    PaidAmount = table.Column<double>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    ShippingDate = table.Column<DateTime>(nullable: false),
                    AssignDate = table.Column<DateTime>(nullable: false),
                    Price = table.Column<double>(nullable: true),
                    DeliveryManId = table.Column<int>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    Status = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Packages_DeliveryMans_DeliveryManId",
                        column: x => x.DeliveryManId,
                        principalTable: "DeliveryMans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Packages_Locations_LocationToId",
                        column: x => x.LocationToId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Packages_PackageCatagories_PackageCatagoryId",
                        column: x => x.PackageCatagoryId,
                        principalTable: "PackageCatagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Packages_PickUpRequests_PickUpRequestId",
                        column: x => x.PickUpRequestId,
                        principalTable: "PickUpRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packages_DeliveryManId",
                table: "Packages",
                column: "DeliveryManId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_LocationToId",
                table: "Packages",
                column: "LocationToId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PackageCatagoryId",
                table: "Packages",
                column: "PackageCatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Packages_PickUpRequestId",
                table: "Packages",
                column: "PickUpRequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "PackageCatagories");

            migrationBuilder.DropColumn(
                name: "PickupAddress",
                table: "PickUpRequests");
        }
    }
}
