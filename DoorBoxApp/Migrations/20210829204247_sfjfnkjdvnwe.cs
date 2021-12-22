using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class sfjfnkjdvnwe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DeliveryDeliveryManPaid",
                table: "Packages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MerchantPaid",
                table: "Packages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "PaidForDelivery",
                table: "Packages",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PaidForPickUp",
                table: "Packages",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PickUpDeliveryManPaid",
                table: "Packages",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveryDeliveryManPaid",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "MerchantPaid",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PaidForDelivery",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PaidForPickUp",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PickUpDeliveryManPaid",
                table: "Packages");
        }
    }
}
