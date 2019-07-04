using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbSkills",
                columns: new[] { "CoreKbSkillID", "CoreSkill", "CoreSkillCategoryID" },
                values: new object[,]
                {
                    { 13, "Team Building ", 2 },
                    { 28, "Managing Remote Teams", 2 },
                    { 27, "Manager Management", 2 },
                    { 26, "Managing", 2 },
                    { 25, "Supervising", 2 },
                    { 24, "Decision Making", 2 },
                    { 23, "Managing Difficult Conversations", 2 },
                    { 22, "Giving Feedback", 2 },
                    { 21, "Diplomacy", 2 },
                    { 20, "Delegation", 2 },
                    { 19, "Mentoring", 2 },
                    { 18, "Coaching", 2 },
                    { 17, "Strategic Planning", 2 },
                    { 16, "Dispute Resolution", 2 },
                    { 15, "Performance Management", 2 },
                    { 14, "Talent Management", 2 },
                    { 29, "Managing Virtual Teams", 2 },
                    { 30, "Crisis Management", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 30);
        }
    }
}
