using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoreKbIndustrySectors",
                columns: table => new
                {
                    CoreKbIndustrySectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKbIndustryID = table.Column<int>(nullable: false),
                    IndustrySectorName = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbIndustrySectors", x => x.CoreKbIndustrySectorID);
                    table.ForeignKey(
                        name: "FK_CoreKbIndustrySectors_CoreKbIndustries",
                        column: x => x.CoreKbIndustryID,
                        principalTable: "CoreKbIndustries",
                        principalColumn: "CoreKbIndustryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRelatedIndustrySectors",
                columns: table => new
                {
                    CompanyRelatedIndustrySectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyRelatedIndustryID = table.Column<int>(nullable: false),
                    CoreKbIndustrySectorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRelatedIndustrySectors", x => x.CompanyRelatedIndustrySectorID);
                    table.ForeignKey(
                        name: "FK_CompanyRelatedIndustrySectors_CompanyRelatedIndustries",
                        column: x => x.CompanyRelatedIndustryID,
                        principalTable: "CompanyRelatedIndustries",
                        principalColumn: "CompanyRelatedIndustryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyRelatedIndustrySectors_CoreKbIndustrySectors",
                        column: x => x.CoreKbIndustrySectorID,
                        principalTable: "CoreKbIndustrySectors",
                        principalColumn: "CoreKbIndustrySectorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyJobRelatedIndustrySectors",
                columns: table => new
                {
                    CompanyJobRelatedIndustrySectorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyRelatedIndustrySectorID = table.Column<int>(nullable: false),
                    CompanyJobID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobRelatedIndustrySectors", x => x.CompanyJobRelatedIndustrySectorID);
                    table.ForeignKey(
                        name: "FK_CompnayJobRelatedIndustrySectors_CompanyJobs",
                        column: x => x.CompanyJobID,
                        principalTable: "CompanyJobs",
                        principalColumn: "CompanyJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompnayJobRelatedIndustrySectors_CompanyRelatedIndustrySectors",
                        column: x => x.CompanyRelatedIndustrySectorID,
                        principalTable: "CompanyRelatedIndustrySectors",
                        principalColumn: "CompanyRelatedIndustrySectorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRelatedIndustrySectors_CompanyJobID",
                table: "CompanyJobRelatedIndustrySectors",
                column: "CompanyJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRelatedIndustrySectors_CompanyRelatedIndustrySectorID",
                table: "CompanyJobRelatedIndustrySectors",
                column: "CompanyRelatedIndustrySectorID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRelatedIndustrySectors_CompanyRelatedIndustryID",
                table: "CompanyRelatedIndustrySectors",
                column: "CompanyRelatedIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRelatedIndustrySectors_CoreKbIndustrySectorID",
                table: "CompanyRelatedIndustrySectors",
                column: "CoreKbIndustrySectorID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKbIndustrySectors_CoreKbIndustryID",
                table: "CoreKbIndustrySectors",
                column: "CoreKbIndustryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyJobRelatedIndustrySectors");

            migrationBuilder.DropTable(
                name: "CompanyRelatedIndustrySectors");

            migrationBuilder.DropTable(
                name: "CoreKbIndustrySectors");
        }
    }
}
