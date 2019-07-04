using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyBranches",
                table: "CompanyJobAssociatedBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyJobs",
                table: "CompanyJobAssociatedBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyBranches",
                table: "CompanyRepresentiveBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyRepresentatives",
                table: "CompanyRepresentiveBranches");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyBranches",
                table: "CompanyJobAssociatedBranches",
                column: "CompanyBranchID",
                principalTable: "CompanyBranches",
                principalColumn: "CompanyBranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyJobs",
                table: "CompanyJobAssociatedBranches",
                column: "CompanyJobID",
                principalTable: "CompanyJobs",
                principalColumn: "CompanyJobID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyBranches",
                table: "CompanyRepresentiveBranches",
                column: "CompanyBranchID",
                principalTable: "CompanyBranches",
                principalColumn: "CompanyBranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyRepresentatives",
                table: "CompanyRepresentiveBranches",
                column: "CompanyRepresentativeID",
                principalTable: "CompanyRepresentatives",
                principalColumn: "CompanyRepresentativeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyBranches",
                table: "CompanyJobAssociatedBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyJobs",
                table: "CompanyJobAssociatedBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyBranches",
                table: "CompanyRepresentiveBranches");

            migrationBuilder.DropForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyRepresentatives",
                table: "CompanyRepresentiveBranches");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyBranches",
                table: "CompanyJobAssociatedBranches",
                column: "CompanyBranchID",
                principalTable: "CompanyBranches",
                principalColumn: "CompanyBranchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyJobAssociatedBranches_CompanyJobs",
                table: "CompanyJobAssociatedBranches",
                column: "CompanyJobID",
                principalTable: "CompanyJobs",
                principalColumn: "CompanyJobID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyBranches",
                table: "CompanyRepresentiveBranches",
                column: "CompanyBranchID",
                principalTable: "CompanyBranches",
                principalColumn: "CompanyBranchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompnayRepresentiveBanches_CompanyRepresentatives",
                table: "CompanyRepresentiveBranches",
                column: "CompanyRepresentativeID",
                principalTable: "CompanyRepresentatives",
                principalColumn: "CompanyRepresentativeID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
