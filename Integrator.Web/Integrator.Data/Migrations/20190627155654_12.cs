using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbIndustries",
                columns: new[] { "CoreKbIndustryID", "CoreKbIndustryCategoryID", "CoreKBIndustryName" },
                values: new object[,]
                {
                    { 66, 10, "Monetary Authorities-Central Bank" },
                    { 92, 15, "Educational Support Services" },
                    { 93, 16, "Ambulatory Health Care Services" },
                    { 94, 16, "Hospitals" },
                    { 95, 16, "Nursing and Residential Care Facilities" },
                    { 96, 16, "Social Assistance" },
                    { 97, 17, "Performing Arts, Spectator Sports, and Related Industries" },
                    { 98, 17, "Museums, Historical Sites, and Similar Institutions" },
                    { 99, 17, "Amusement, Gambling, and Recreation Industries" },
                    { 100, 18, "Accommodation" },
                    { 91, 15, "Other Schools and Instruction" },
                    { 101, 18, "Food Services and Drinking Places" },
                    { 103, 19, "Personal and Laundry Services" },
                    { 104, 19, "Religious, Grantmaking, Civic, Professional, and Similar Organizations" },
                    { 105, 19, "Private Households" },
                    { 106, 20, "Executive, Legislative, and Other General Government Support" },
                    { 107, 20, "Justice, Public Order, and Safety Activities" },
                    { 108, 20, "Administration of Human Resource Programs" },
                    { 109, 20, "Administration of Environmental Quality Programs" },
                    { 110, 20, "Administration of Housing Programs, Urban Planning, and Community Development " },
                    { 111, 20, "Administration of Economic Programs " },
                    { 102, 19, "Repair and Maintenances" },
                    { 90, 15, "Technical and Trade Schools" },
                    { 89, 15, "Business Schools and Computer and Management Training" },
                    { 88, 15, "Colleges, Universities, and Professional Schools" },
                    { 67, 10, "Credit Intermediation and Related Activities" },
                    { 68, 10, "Securities, Commodity Contracts, and Other Financial Investments" },
                    { 69, 10, "Insurance Carriers and Related Activities" },
                    { 70, 10, "Funds, Trusts, and Other Financial Vehicles" },
                    { 71, 11, "Real Estate" },
                    { 72, 11, "Rental and Leasing Services" },
                    { 73, 11, "Lessors of Nonfinancial Intangible Assets" },
                    { 74, 12, "Legal Services" },
                    { 75, 12, "Accounting, Tax Preparation, Bookkeeping, and Payroll Services" },
                    { 76, 12, "Lessors of Nonfinancial Intangible Assets" },
                    { 77, 12, "Architectural, Engineering, and Related Services" },
                    { 78, 12, "Specialized Design Services" },
                    { 79, 12, "Management, Scientific, and Technical Consulting Services" },
                    { 80, 12, "Scientific Research and Development Services" },
                    { 81, 12, "Advertising, Public Relations, and Related Services" },
                    { 82, 12, "Other Professional, Scientific, and Technical Services" },
                    { 83, 13, "Management of Companies and Enterprises" },
                    { 84, 14, "Administrative and Support Services" },
                    { 85, 14, "Waste Management and Remediation Services" },
                    { 86, 15, "Elementary and Secondary Schools" },
                    { 87, 15, "Junior Colleges" },
                    { 112, 20, "Space Research and Technology" },
                    { 113, 20, "National Security and International Affairs" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "CoreKbIndustries",
                keyColumn: "CoreKbIndustryID",
                keyValue: 113);
        }
    }
}
