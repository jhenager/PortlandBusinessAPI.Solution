using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PortlandBusiness.Migrations
{
    public partial class Split : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.RestaurantId);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Downtown Arcade Bar", "Ground Kontrol", "Bar" },
                    { 2, "Restaurant and Deli providing fine meats", "Laurelhurst Market", "Steakhouse" },
                    { 3, "Korean desserts and coffee drinks", "Soro Soro", "Dessert" },
                    { 4, "Delicious local Portland brewery", "Breakside Brewery", "Brewery" },
                    { 5, "Best Sushi in town", "Miyamoto Sushi", "Restaurant" }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Large Bookstore", "Powells Books" },
                    { 2, "Crafts and Records", "Tender Loving Empire" },
                    { 3, "Portland's best record store", "Music Millenium" },
                    { 4, "Artsy Comic book shop", "Floating World" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Large Bookstore", "Powells Books", "Retail" },
                    { 2, "Downtown Arcade Bar", "Ground Kontrol", "Bar" },
                    { 3, "Restaurant and Deli providing fine meats", "Laurelhurst Market", "Restaurant" },
                    { 4, "Korean desserts and coffee drinks", "Soro Soro", "Cafe" },
                    { 5, "Small live music venue", "Mississippi Studios", "Venue" },
                    { 6, "Delicious local Portland brewery", "Breakside Brewery", "Brewery" },
                    { 7, "Best Sushi in town", "Miyamoto Sushi", "Restaurant" }
                });
        }
    }
}
