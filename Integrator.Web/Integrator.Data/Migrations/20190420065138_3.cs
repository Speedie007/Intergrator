using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbIndustryCategories",
                columns: new[] { "CoreKbIndustryCategoryID", "CoreKBIndustryCategory" },
                values: new object[,]
                {
                    { 1, "Agriculture and Mining" },
                    { 2, "Business Services" },
                    { 3, "Education" },
                    { 4, "Consumer Services" },
                    { 5, "Education" },
                    { 6, "Energy and Utilities" }
                });

            migrationBuilder.InsertData(
                table: "CoreKbIndustries",
                columns: new[] { "CoreKbIndustryID", "CoreKbIndustryCategoryID", "CoreKBIndustryName" },
                values: new object[,]
                {
                    { 1, 1, "Farming and Ranching" },
                    { 2, 1, "Fishing" },
                    { 3, 1, "Hunting " },
                    { 4, 1, "Forestry" },
                    { 5, 1, "Mining and Quarrying" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 1);
        }
    }
}
