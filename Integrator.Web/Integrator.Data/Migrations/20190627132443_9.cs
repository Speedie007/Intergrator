using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbIndustries",
                columns: new[] { "CoreKbIndustryID", "CoreKbIndustryCategoryID", "CoreKBIndustryName" },
                values: new object[,]
                {
                    { 12, 4, "Construction of Buildings" },
                    { 32, 5, "Transportation Equipment Manufacturing" },
                    { 31, 5, "Electrical Equipment, Appliance, and Component Manufacturing" },
                    { 30, 5, "Computer and Electronic Product Manufacturing" },
                    { 29, 5, "Machinery Manufacturing" },
                    { 28, 5, "Fabricated Metal Product Manufacturing" },
                    { 27, 5, "Primary Metal Manufacturing" },
                    { 26, 5, "Nonmetallic Mineral Product Manufacturing" },
                    { 25, 5, "Plastics and Rubber Products Manufacturing" },
                    { 24, 5, "Chemical Manufacturing" },
                    { 33, 5, "Furniture and Related Product Manufacturing" },
                    { 23, 5, "Petroleum and Coal Products Manufacturing" },
                    { 21, 5, "Paper Manufacturing" },
                    { 20, 5, "Wood Product Manufacturing" },
                    { 19, 5, "Leather and Allied Product Manufacturing" },
                    { 18, 5, "Apparel Manufacturing" },
                    { 17, 5, "Textile Mills" },
                    { 16, 5, "Beverage and Tobacco Product Manufacturing" },
                    { 15, 5, "Food Manufacturing" },
                    { 14, 4, "Specialty Trade Contractors" },
                    { 13, 4, "Heavy and Civil Engineering Construction" },
                    { 22, 5, "Printing and Related Support Activities" },
                    { 34, 5, "Miscellaneous Manufacturing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 34);
        }
    }
}
