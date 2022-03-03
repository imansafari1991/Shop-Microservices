using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    public partial class seedproductdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 852, DateTimeKind.Utc).AddTicks(9341),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 840, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 852, DateTimeKind.Utc).AddTicks(9180),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 840, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 853, DateTimeKind.Utc).AddTicks(2951),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 841, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 853, DateTimeKind.Utc).AddTicks(2818),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 841, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Active", "CategoryId", "Code", "Description", "Permalink", "Price", "Title" },
                values: new object[,]
                {
                    { 1, true, 10, "James", "Quis consequat eiusmod qui aliqua. Mollit nisi minim non eu et fugiat minim sunt dolor deserunt reprehenderit. Cillum velit aliqua aute ipsum. Non commodo voluptate enim eiusmod. Magna pariatur reprehenderit aliqua officia incididunt in.\r\n", "Myers-Pierce", 0m, "Lilia Greer" },
                    { 2, false, 10, "Nielsen", "Irure exercitation duis magna adipisicing labore ullamco reprehenderit enim ut id excepteur tempor veniam incididunt. Nostrud dolor incididunt enim aute nulla est exercitation enim. Elit officia magna est aliquip pariatur ex sit sint id.\r\n", "Colette-Barker", 0m, "Mcintosh Rhodes" },
                    { 3, true, 7, "Avis", "Sint nostrud velit voluptate aute laboris proident Lorem ea. Laboris nulla officia voluptate do enim mollit mollit quis nostrud. Sint fugiat deserunt voluptate consectetur commodo officia eiusmod ut laborum. Lorem cillum laborum cillum voluptate in ullamco anim ad sint nulla consectetur irure.\r\n", "Buck-Espinoza", 0m, "Joni Gross" },
                    { 4, false, 8, "Juliet", "Tempor officia aliquip ea reprehenderit pariatur amet. Ut aliquip anim excepteur magna ea eiusmod eiusmod occaecat laboris. Ipsum voluptate pariatur amet cillum esse nulla occaecat reprehenderit id officia qui. Occaecat laboris adipisicing proident et labore nisi cillum in nostrud irure ipsum aute sunt nostrud. Non ea voluptate irure eu velit veniam. Incididunt cupidatat mollit consectetur eiusmod aute in reprehenderit enim duis esse occaecat excepteur cillum. Eiusmod enim ipsum eiusmod tempor Lorem est qui aute voluptate consectetur irure in.\r\n", "Perkins-Jarvis", 0m, "Campbell Foster" },
                    { 5, false, 5, "Alisha", "Adipisicing in irure eiusmod aliqua labore. Velit dolore qui ut consectetur qui amet aute commodo incididunt. Velit veniam adipisicing nisi laborum ea id. Esse sint consequat irure ipsum non labore.\r\n", "Deirdre-Dale", 0m, "Ruth Hobbs" },
                    { 6, false, 4, "Margo", "Laboris fugiat commodo laborum esse non tempor nostrud tempor occaecat velit. Aliqua voluptate sit dolor consectetur ut commodo labore irure dolor in consequat. Sint cillum non eu commodo. Proident anim minim eu nulla labore incididunt in aliquip magna deserunt irure quis culpa. Velit qui consequat veniam id minim. Cillum commodo nostrud cupidatat eu pariatur in Lorem velit minim.\r\n", "Nellie-Wallace", 0m, "Dianne Simon" },
                    { 7, false, 2, "Tina", "Laboris in Lorem veniam commodo dolor esse mollit quis amet id reprehenderit labore duis ex. Non proident cupidatat duis occaecat dolore. Non deserunt deserunt adipisicing sint dolor reprehenderit reprehenderit Lorem excepteur anim. Dolor esse minim velit aute anim nostrud et sunt quis labore. Non incididunt culpa amet sit veniam magna nulla proident adipisicing exercitation ipsum nostrud.\r\n", "Carmen-Garrett", 0m, "Trisha Mathews" },
                    { 8, false, 7, "Becker", "Enim duis ea labore fugiat minim amet ullamco. Deserunt exercitation duis dolore commodo velit. Officia nisi laboris cupidatat amet laboris exercitation esse sunt. Commodo enim consequat in adipisicing eiusmod nulla laboris.\r\n", "Tia-Fitzgerald", 0m, "Lacey Good" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 840, DateTimeKind.Utc).AddTicks(9657),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 852, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 840, DateTimeKind.Utc).AddTicks(9455),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 852, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModificationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 841, DateTimeKind.Utc).AddTicks(885),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 853, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(2022, 3, 3, 15, 42, 39, 841, DateTimeKind.Utc).AddTicks(694),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValue: new DateTime(2022, 3, 3, 15, 49, 23, 853, DateTimeKind.Utc).AddTicks(2818));
        }
    }
}
