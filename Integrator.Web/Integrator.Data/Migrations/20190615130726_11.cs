using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyJobRepresentitives",
                columns: table => new
                {
                    CompanyJobRepresentitiveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyRepresentativeID = table.Column<int>(nullable: false),
                    CompanyJobID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobRepresentitives", x => x.CompanyJobRepresentitiveID);
                    table.ForeignKey(
                        name: "FK_CompanyJobRepresentitives_CompanyJobs",
                        column: x => x.CompanyJobID,
                        principalTable: "CompanyJobs",
                        principalColumn: "CompanyJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyJobRepresentitives_CompanyRepresentatives",
                        column: x => x.CompanyRepresentativeID,
                        principalTable: "CompanyRepresentatives",
                        principalColumn: "CompanyRepresentativeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRelatedIndustryRepresentives",
                columns: table => new
                {
                    CompanyRelatedIndustryRepresentiveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyRelatedIndustryID = table.Column<int>(nullable: false),
                    CompanyRepresentativeID = table.Column<int>(nullable: false),
                    DateAssigned = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRelatedIndustryRepresentives", x => x.CompanyRelatedIndustryRepresentiveID);
                    table.ForeignKey(
                        name: "FK_CompanyRelatedIndustryRepresentives_CompanyRelatedIndustries",
                        column: x => x.CompanyRelatedIndustryID,
                        principalTable: "CompanyRelatedIndustries",
                        principalColumn: "CompanyRelatedIndustryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyRelatedIndustryRepresentives_CompanyRepresentatives",
                        column: x => x.CompanyRepresentativeID,
                        principalTable: "CompanyRepresentatives",
                        principalColumn: "CompanyRepresentativeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRepresentitives_CompanyJobID",
                table: "CompanyJobRepresentitives",
                column: "CompanyJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRepresentitives_CompanyRepresentativeID",
                table: "CompanyJobRepresentitives",
                column: "CompanyRepresentativeID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRelatedIndustryRepresentives_CompanyRelatedIndustryID",
                table: "CompanyRelatedIndustryRepresentives",
                column: "CompanyRelatedIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRelatedIndustryRepresentives_CompanyRepresentativeID",
                table: "CompanyRelatedIndustryRepresentives",
                column: "CompanyRepresentativeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyJobRepresentitives");

            migrationBuilder.DropTable(
                name: "CompanyRelatedIndustryRepresentives");
        }
    }
}
