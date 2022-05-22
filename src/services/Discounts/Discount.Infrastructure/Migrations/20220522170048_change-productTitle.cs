using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Discount.Infrastructure.Migrations
{
    public partial class changeproductTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Coupons");

            migrationBuilder.AddColumn<string>(
                name: "ProductTitle",
                table: "Coupons",
                type: "character varying(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductTitle",
                table: "Coupons");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Coupons",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
