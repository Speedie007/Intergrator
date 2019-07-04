using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 1,
                column: "CoreKBIndustryCategory",
                value: "Agriculture, Forestry, Fishing and Hunting");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 2,
                column: "CoreKBIndustryCategory",
                value: "Mining, Quarrying, and Oil and Gas Extraction");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 3,
                column: "CoreKBIndustryCategory",
                value: "Utilities");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 4,
                column: "CoreKBIndustryCategory",
                value: "Construction");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 5,
                column: "CoreKBIndustryCategory",
                value: "Manufacturing");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 6,
                column: "CoreKBIndustryCategory",
                value: "Wholesale Trade");

            migrationBuilder.InsertData(
                table: "CoreKbIndustryCategories",
                columns: new[] { "CoreKbIndustryCategoryID", "CoreKBIndustryCategory" },
                values: new object[,]
                {
                    { 18, "Accommodation and Food Services" },
                    { 17, "Arts, Entertainment, and Recreation" },
                    { 16, "Health Care and Social Assistance" },
                    { 15, "Educational Services" },
                    { 14, "Administrative, Support, Waste Management and Remediation Services" },
                    { 13, "Management of Companies and Enterprises" },
                    { 10, "Finance and Insurance" },
                    { 11, "Real Estate and Rental and Leasing" },
                    { 19, "Other Services (Except Public Administration)" },
                    { 9, "Information" },
                    { 8, "Transportation and Warehousing" },
                    { 7, "Retail Trade" },
                    { 12, "Professional, Scientific, and Technical Services" },
                    { 20, "Public Administration" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 1,
                column: "CoreKBIndustryCategory",
                value: "Agriculture and Mining");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 2,
                column: "CoreKBIndustryCategory",
                value: "Business Services");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 3,
                column: "CoreKBIndustryCategory",
                value: "Education");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 4,
                column: "CoreKBIndustryCategory",
                value: "Consumer Services");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 5,
                column: "CoreKBIndustryCategory",
                value: "Education");

            migrationBuilder.UpdateData(
                table: "CoreKbIndustryCategories",
                keyColumn: "CoreKbIndustryCategoryID",
                keyValue: 6,
                column: "CoreKBIndustryCategory",
                value: "Energy and Utilities");
        }
    }
}
