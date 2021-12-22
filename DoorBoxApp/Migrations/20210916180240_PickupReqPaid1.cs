using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class PickupReqPaid1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaidForDelivery",
                table: "PickUpRequests",
                newName: "PaidForPickUp");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PaidForPickUp",
                table: "PickUpRequests",
                newName: "PaidForDelivery");
        }
    }
}
