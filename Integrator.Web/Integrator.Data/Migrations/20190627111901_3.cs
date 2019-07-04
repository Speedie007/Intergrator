using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbSkills",
                columns: new[] { "CoreKbSkillID", "CoreSkill", "CoreSkillCategoryID" },
                values: new object[,]
                {
                    { 1, "Verbal Communication", 1 },
                    { 2, "Body Language", 1 },
                    { 3, "Physical Communication", 1 },
                    { 4, "Writing ", 1 },
                    { 5, "Storytelling ", 1 },
                    { 6, "Visual Communication", 1 },
                    { 7, "Humor ", 1 },
                    { 8, "Quick-wittedness ", 1 },
                    { 9, "Listening ", 1 },
                    { 10, "Presentation", 1 },
                    { 11, "Public Speaking", 1 },
                    { 12, "Interviewing ", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 12);
        }
    }
}
