using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbIndustries",
                columns: new[] { "CoreKbIndustryID", "CoreKbIndustryCategoryID", "CoreKBIndustryName" },
                values: new object[,]
                {
                    { 35, 6, "Merchant Wholesalers, Durable Goods" },
                    { 36, 6, "Merchant Wholesalers, Non-Durable Goods" },
                    { 37, 6, "Wholesale Electronic Markets and Agents and Brokers" },
                    { 38, 7, "Motor Vehicle and Parts Dealers" },
                    { 39, 7, "Furniture and Home Furnishings Stores" },
                    { 40, 7, "Electronics and Appliance Stores" },
                    { 41, 7, "Building Material, Garden Equipment and Supplies Dealers" },
                    { 42, 7, "Food and Beverage Stores" },
                    { 43, 7, "Health and Personal Care Stores" },
                    { 44, 7, "Gasoline Stations" },
                    { 45, 7, "Clothing and Clothing Accessories Stores" },
                    { 46, 7, "Sporting Goods, Hobby, Musical Instrument, and Book Stores" },
                    { 47, 7, "General Merchandise Stores" },
                    { 48, 7, "Miscellaneous Store Retailers" },
                    { 49, 7, "Nonstore Retailers" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 49);
        }
    }
}
