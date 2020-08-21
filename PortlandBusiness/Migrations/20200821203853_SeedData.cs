using Microsoft.EntityFrameworkCore.Migrations;

namespace PortlandBusiness.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 7);
        }
    }
}
