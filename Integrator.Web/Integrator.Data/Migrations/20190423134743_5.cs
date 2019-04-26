using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LevelOfIndustInvolvement",
                table: "UserJobRelatedIndustries",
                newName: "LevelOfIndustryInvolvement");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LevelOfIndustryInvolvement",
                table: "UserJobRelatedIndustries",
                newName: "LevelOfIndustInvolvement");
        }
    }
}
