using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    public partial class addproductdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 345, DateTimeKind.Utc).AddTicks(4),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 344, DateTimeKind.Utc).AddTicks(9623),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 343, DateTimeKind.Utc).AddTicks(7240),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 343, DateTimeKind.Utc).AddTicks(7008),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(2146));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(7564),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 345, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(7344),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 344, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(2428),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 343, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(2146),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 26, 16, 41, 8, 343, DateTimeKind.Utc).AddTicks(7008));
        }
    }
}
