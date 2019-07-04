using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 1,
                column: "CoreKBIndustryName",
                value: "Crop Production");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 2,
                column: "CoreKBIndustryName",
                value: "Animal Production and Aquaculture");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 3,
                column: "CoreKBIndustryName",
                value: "Forestry and Logging");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 4,
                column: "CoreKBIndustryName",
                value: "Fishing, Hunting and Trapping");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 5,
                column: "CoreKBIndustryName",
                value: "Support Activities for Agriculture and Forestry");

            migrationBuilder.InsertData(
                table: "CoreKbIndustries",
                columns: new[] { "CoreKbIndustryID", "CoreKbIndustryCategoryID", "CoreKBIndustryName" },
                values: new object[,]
                {
                    { 6, 2, "Oil and Gas Extraction" },
                    { 7, 2, "Mining (except Oil and Gas)" },
                    { 8, 2, "Support Activities for Mining" },
                    { 9, 3, "Electric Power Generation, Transmission and Distribution" },
                    { 10, 3, "Natural Gas Distribution" },
                    { 11, 3, "Water, Sewage and Other Systems" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 1,
                column: "CoreKBIndustryName",
                value: "Farming and Ranching");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 2,
                column: "CoreKBIndustryName",
                value: "Fishing");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 3,
                column: "CoreKBIndustryName",
                value: "Hunting ");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 4,
                column: "CoreKBIndustryName",
                value: "Forestry");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 5,
                column: "CoreKBIndustryName",
                value: "Mining and Quarrying");
        }
    }
}
