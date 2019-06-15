using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserJobSkills_CoreKBSkills",
                table: "UserJobSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobSkills_UserJobs",
                table: "UserJobSkills");

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobSkills_CoreKBSkills",
                table: "UserJobSkills",
                column: "CoreKbSkillID",
                principalTable: "CoreKbSkills",
                principalColumn: "CoreKbSkillID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobSkills_UserJobs",
                table: "UserJobSkills",
                column: "UserJobID",
                principalTable: "UserJobs",
                principalColumn: "UserJobID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserJobSkills_CoreKBSkills",
                table: "UserJobSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobSkills_UserJobs",
                table: "UserJobSkills");

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobSkills_CoreKBSkills",
                table: "UserJobSkills",
                column: "CoreKbSkillID",
                principalTable: "CoreKbSkills",
                principalColumn: "CoreKbSkillID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobSkills_UserJobs",
                table: "UserJobSkills",
                column: "UserJobID",
                principalTable: "UserJobs",
                principalColumn: "UserJobID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
