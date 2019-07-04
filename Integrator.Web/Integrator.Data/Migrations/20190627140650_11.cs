using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbIndustries",
                columns: new[] { "CoreKbIndustryID", "CoreKbIndustryCategoryID", "CoreKBIndustryName" },
                values: new object[,]
                {
                    { 50, 8, "Air Transportation" },
                    { 51, 8, "Rail Transportation" },
                    { 52, 8, "Water Transportation" },
                    { 53, 8, "Truck Transportation" },
                    { 54, 8, "Pipeline Transportation" },
                    { 55, 8, "Scenic and Sightseeing Transportation" },
                    { 56, 8, "Support Activities for Transportation" },
                    { 57, 8, "Postal Service" },
                    { 58, 8, "Couriers and Messengers" },
                    { 59, 8, "Warehousing and Storage" },
                    { 60, 9, "Publishing Industries (Except Internet)" },
                    { 61, 9, "Motion Picture and Sound Recording Industries" },
                    { 62, 9, "Broadcasting (except Internet)" },
                    { 63, 9, "Data Processing, Hosting, and Related Services" },
                    { 64, 9, "Other Information Services" },
                    { 65, 9, "Telecommunications" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 65);
        }
    }
}
