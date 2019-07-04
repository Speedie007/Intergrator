using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbSkills",
                columns: new[] { "CoreKbSkillID", "CoreSkill", "CoreSkillCategoryID" },
                values: new object[,]
                {
                    { 31, "Facilitation", 3 },
                    { 59, "Friendliness", 5 },
                    { 58, "Work-Life Balance", 5 },
                    { 57, "Self Assessment", 5 },
                    { 56, "Self Leadership", 5 },
                    { 55, "Competitiveness", 5 },
                    { 54, "Assertiveness", 5 },
                    { 53, "Resilience", 5 },
                    { 52, "Adaptability", 5 },
                    { 51, "Self Confidence", 5 },
                    { 50, "Taking Criticism", 5 },
                    { 49, "Tolerance of Change and Uncertainty", 5 },
                    { 48, "Stress Management", 5 },
                    { 47, "Emotion Management", 5 },
                    { 60, "Enthusiasm", 5 },
                    { 46, "Self Awareness", 5 },
                    { 44, "Emotional Intelligence", 5 },
                    { 43, "Office Politics", 4 },
                    { 42, "Personal Branding", 4 },
                    { 41, "Conflict Resolution", 4 },
                    { 40, "Dealing with Difficult People", 4 },
                    { 39, "Interpersonal Relationships", 4 },
                    { 38, "Networking", 4 },
                    { 37, "Collaborating", 3 },
                    { 36, "Motivating", 3 },
                    { 35, "Negotiation", 3 },
                    { 34, "Persuasion", 3 },
                    { 33, "Inspiring", 3 },
                    { 32, "Selling", 3 },
                    { 45, "Office Politics", 5 },
                    { 61, "Empathy", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 61);
        }
    }
}
