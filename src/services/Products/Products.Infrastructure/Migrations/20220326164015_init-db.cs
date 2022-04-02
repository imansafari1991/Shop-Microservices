using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Products.Infrastructure.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    ParentCategoryId = table.Column<int>(type: "integer", nullable: true),
                    Permalink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    BannerUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/500x100.png"),
                    IconUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/85.png"),
                    ThumbnailUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150x150.png"),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(2146)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(2428))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(5000)", maxLength: 5000, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Permalink = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CoverImageUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false, defaultValue: "https://via.placeholder.com/150x150.png"),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(7344)),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValue: new DateTime(2022, 3, 26, 16, 40, 14, 775, DateTimeKind.Utc).AddTicks(7564))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 1, false, "Aliquip Lorem deserunt cupidatat deserunt sit qui excepteur. Ea aliquip eu irure et fugiat esse sit duis ad cillum mollit. Consectetur exercitation qui ea mollit enim ipsum excepteur. In velit aliqua adipisicing velit non in nisi commodo cupidatat Lorem voluptate labore. Enim cillum do ullamco proident ullamco ex Lorem consequat elit veniam sunt minim Lorem.\r\n", null, "Lancaster-Greene", 4, "Baird Moreno" },
                    { 2, false, "Adipisicing in aliquip duis excepteur laborum ullamco commodo duis consectetur elit labore sint. Eiusmod duis esse ex deserunt ipsum id adipisicing occaecat veniam proident ad. Occaecat officia enim eu laboris et in nulla nulla voluptate ad. Ullamco eiusmod reprehenderit amet ad enim. Sit Lorem cillum consectetur amet minim officia nulla. Ex ipsum Lorem consequat adipisicing.\r\n", null, "Bullock-Odonnell", 1, "Carr Simmons" },
                    { 3, false, "Reprehenderit nisi anim irure irure officia laborum incididunt anim. Laborum laborum adipisicing adipisicing incididunt velit labore dolor ut. Consectetur culpa ut nisi officia excepteur reprehenderit ad eu consequat voluptate sint.\r\n", null, "Walker-Rose", 3, "Barrera Hogan" },
                    { 4, false, "Ullamco est eiusmod sint laboris elit esse. Adipisicing minim dolore irure ut tempor culpa non consequat nostrud Lorem mollit aliquip. Aliquip nisi Lorem laborum nostrud eiusmod nisi anim officia eiusmod anim culpa. Qui elit cillum id eiusmod.\r\n", null, "Karyn-Mccullough", 2, "Carrillo Maddox" },
                    { 5, true, "Pariatur proident eu velit consectetur ullamco. Velit do esse magna esse proident incididunt laborum elit enim occaecat incididunt anim fugiat. Lorem deserunt adipisicing excepteur et. Dolor officia et in ex id fugiat. Culpa elit ullamco enim eu amet pariatur eiusmod do.\r\n", null, "Keith-Underwood", 1, "Mccray Hoover" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[,]
                {
                    { 6, true, "In culpa commodo Lorem reprehenderit consectetur consectetur. Esse elit exercitation enim non mollit ea deserunt nisi nostrud consequat labore duis proident. Fugiat sint mollit Lorem quis voluptate reprehenderit tempor ut velit elit amet. Deserunt veniam officia incididunt reprehenderit.\r\n", 1, "Kris-Schultz", 5, "Nelson Mckinney" },
                    { 7, true, "Dolor qui ad exercitation in anim proident aliquip consectetur. Eu eiusmod laboris proident reprehenderit reprehenderit anim exercitation dolore culpa occaecat eu nostrud eiusmod sunt. Occaecat deserunt ullamco occaecat non cillum tempor. Cupidatat sint ad ipsum elit ad mollit exercitation. Esse aliquip sunt proident laborum cillum esse nulla do mollit. Laborum est veniam veniam occaecat tempor laboris qui do elit incididunt. Nulla aliquip cupidatat ex voluptate eu id sint aliquip incididunt enim.\r\n", 2, "Mays-Dennis", 4, "Violet Clarke" },
                    { 8, true, "Deserunt nisi sint magna magna ad fugiat esse culpa ipsum cillum ullamco. Minim fugiat duis reprehenderit sint nisi exercitation qui cupidatat duis velit ut in cillum eiusmod. Ea aliquip sunt et qui ea ipsum aliqua minim ex ad culpa ea. Labore qui in tempor eu voluptate duis cupidatat aliqua do veniam dolore Lorem. Labore cupidatat Lorem sunt ad aliquip eiusmod non culpa pariatur ullamco do exercitation sunt minim.\r\n", 3, "Lewis-Avila", 2, "Krystal Johnson" },
                    { 9, false, "Magna aute adipisicing amet deserunt sint quis dolor mollit nisi officia qui reprehenderit duis occaecat. Consequat sit sit quis dolore sunt nulla cupidatat et tempor consectetur duis labore elit. Aute adipisicing ullamco incididunt fugiat esse aliqua elit velit. Culpa amet aute do velit anim pariatur. Pariatur ex quis ex dolor est qui. Non velit anim et laboris adipisicing nostrud proident do proident mollit elit minim. Occaecat mollit proident nostrud nisi irure ipsum amet incididunt dolore magna ex.\r\n", 4, "Kirk-Spence", 1, "Mack Ross" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Active", "Description", "ParentCategoryId", "Permalink", "Priority", "Title" },
                values: new object[] { 10, false, "Ullamco cupidatat tempor proident deserunt elit occaecat magna est aute. Aliqua excepteur aliquip anim dolore deserunt irure. Ullamco ex nulla ipsum mollit velit aliqua mollit. Deserunt enim quis tempor est esse pariatur aliquip nulla proident officia ullamco commodo. Fugiat qui ipsum officia non sint. Sit reprehenderit aute Lorem nisi quis aliquip culpa sunt cupidatat.\r\n", 9, "Dona-Soto", 1, "Patel Castaneda" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
