using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class PickupReqPaid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PaidForDelivery",
                table: "PickUpRequests",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PickupDeliveryManPaid",
                table: "PickUpRequests",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidForDelivery",
                table: "PickUpRequests");

            migrationBuilder.DropColumn(
                name: "PickupDeliveryManPaid",
                table: "PickUpRequests");
        }
    }
}
