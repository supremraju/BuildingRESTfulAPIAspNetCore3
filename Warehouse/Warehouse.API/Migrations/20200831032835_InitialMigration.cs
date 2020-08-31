using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(nullable: false),
                    productCode = table.Column<string>(nullable: false),
                    releaseDate = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    starRating = table.Column<double>(nullable: false),
                    imageUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
