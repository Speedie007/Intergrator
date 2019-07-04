using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CoreKbSkills",
                columns: new[] { "CoreKbSkillID", "CoreSkill", "CoreSkillCategoryID" },
                values: new object[,]
                {
                    { 62, "Problem Solving", 6 },
                    { 86, "Writing Reports and Proposals", 7 },
                    { 85, "Knowledge Management", 7 },
                    { 84, "Process Improvement", 7 },
                    { 83, "Train the Trainer", 7 },
                    { 82, "Training", 7 },
                    { 81, "Intercultural Competence", 7 },
                    { 80, "Disability Awareness", 7 },
                    { 79, "Diversity Awareness", 7 },
                    { 78, "Business Ethics", 7 },
                    { 77, "Business Etiquette", 7 },
                    { 76, "Research", 7 },
                    { 87, "Customer Service", 7 },
                    { 75, "Business Trend Awareness", 7 },
                    { 73, "Technology Savvy", 7 },
                    { 72, "Meeting Management", 7 },
                    { 71, "Time Management", 7 },
                    { 70, "Scheduling", 7 },
                    { 69, "Planning", 7 },
                    { 68, "Organization", 7 },
                    { 67, "Artistic Sense", 6 },
                    { 66, "Design Sense", 6 },
                    { 65, "Troubleshooting", 6 },
                    { 64, "Innovation", 6 },
                    { 63, "Critical Thinking", 6 },
                    { 74, "Technology Trend Awareness", 7 },
                    { 88, "Entrepreneurial Thinking", 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "CoreKbSkills",
                keyColumn: "CoreKbSkillID",
                keyValue: 88);
        }
    }
}
