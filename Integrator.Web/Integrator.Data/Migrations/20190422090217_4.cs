using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CoreKbSkillTypes",
                keyColumn: "CoreKbSkillTypeID",
                keyValue: 1,
                column: "CoreKBSkillType",
                value: "HardSkill");

            migrationBuilder.UpdateData(
                table: "CoreKbSkillTypes",
                keyColumn: "CoreKbSkillTypeID",
                keyValue: 2,
                column: "CoreKBSkillType",
                value: "SoftSkill");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CoreKbSkillTypes",
                keyColumn: "CoreKbSkillTypeID",
                keyValue: 1,
                column: "CoreKBSkillType",
                value: "Hard");

            migrationBuilder.UpdateData(
                table: "CoreKbSkillTypes",
                keyColumn: "CoreKbSkillTypeID",
                keyValue: 2,
                column: "CoreKBSkillType",
                value: "Soft");
        }
    }
}
