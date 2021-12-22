using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class DmMerchantPickupReqAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DeliveryMans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryManIdNo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NIDNumber = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryMans_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MerchantIdNo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Merchants_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PickUpRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    PickUpDate = table.Column<DateTime>(nullable: false),
                    RequestId = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    LocationFromId = table.Column<int>(nullable: false),
                    PickUpDeliveryManId = table.Column<int>(nullable: true),
                    MerchantId = table.Column<int>(nullable: false),
                    TotalPackageNumber = table.Column<int>(nullable: false),
                    PickedUpPackageNumber = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickUpRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PickUpRequests_Locations_LocationFromId",
                        column: x => x.LocationFromId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PickUpRequests_Merchants_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PickUpRequests_DeliveryMans_PickUpDeliveryManId",
                        column: x => x.PickUpDeliveryManId,
                        principalTable: "DeliveryMans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryMans_ApplicationUserId",
                table: "DeliveryMans",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchants_ApplicationUserId",
                table: "Merchants",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUpRequests_LocationFromId",
                table: "PickUpRequests",
                column: "LocationFromId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUpRequests_MerchantId",
                table: "PickUpRequests",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUpRequests_PickUpDeliveryManId",
                table: "PickUpRequests",
                column: "PickUpDeliveryManId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PickUpRequests");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "DeliveryMans");
        }
    }
}
