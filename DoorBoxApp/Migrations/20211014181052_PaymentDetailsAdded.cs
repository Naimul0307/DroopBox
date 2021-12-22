using Microsoft.EntityFrameworkCore.Migrations;

namespace DoorBoxApp.Migrations
{
    public partial class PaymentDetailsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankCustomerName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileBankingNumber",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoutingNumber",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BankCustomerName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MobileBankingNumber",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RoutingNumber",
                table: "AspNetUsers");
        }
    }
}
