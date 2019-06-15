using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyAddresses",
                columns: table => new
                {
                    CompanyAddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAddresses", x => x.CompanyAddressID);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_Addresses",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContactDetails",
                columns: table => new
                {
                    CompanyContactDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactDetailID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContactDetails", x => x.CompanyContactDetailID);
                    table.ForeignKey(
                        name: "FK_CompanyContactDetails_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyContactDetails_ContactDetails",
                        column: x => x.ContactDetailID,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRepresentatives",
                columns: table => new
                {
                    CompanyRepresentativeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRepresentatives", x => x.CompanyRepresentativeID);
                    table.ForeignKey(
                        name: "FK_CompanyRepresentatives_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyRepresentatives_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_AddressID",
                table: "CompanyAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyAddresses_CompanyID",
                table: "CompanyAddresses",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContactDetails_CompanyID",
                table: "CompanyContactDetails",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContactDetails_ContactDetailID",
                table: "CompanyContactDetails",
                column: "ContactDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRepresentatives_CompanyID",
                table: "CompanyRepresentatives",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRepresentatives_IntegratorUserID",
                table: "CompanyRepresentatives",
                column: "IntegratorUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyAddresses");

            migrationBuilder.DropTable(
                name: "CompanyContactDetails");

            migrationBuilder.DropTable(
                name: "CompanyRepresentatives");
        }
    }
}
