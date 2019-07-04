using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyBranches_Addresses_AddressID",
                table: "CompanyBranches");

            migrationBuilder.DropIndex(
                name: "IX_CompanyBranches_AddressID",
                table: "CompanyBranches");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "CompanyBranches");

            migrationBuilder.RenameColumn(
                name: "BranchName",
                table: "CompanyBranches",
                newName: "BranchDescription");

            migrationBuilder.CreateTable(
                name: "CompanyBranchAddresses",
                columns: table => new
                {
                    CompanyBranchAddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyBranchID = table.Column<int>(nullable: false),
                    AddressID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranchAddresses", x => x.CompanyBranchAddressID);
                    table.ForeignKey(
                        name: "FK_CompanyBranchAddresses_Addresses",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyBranchAddresses_CompanyBranches",
                        column: x => x.CompanyBranchID,
                        principalTable: "CompanyBranches",
                        principalColumn: "CompanyBranchID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranchAddresses_AddressID",
                table: "CompanyBranchAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranchAddresses_CompanyBranchID",
                table: "CompanyBranchAddresses",
                column: "CompanyBranchID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyBranchAddresses");

            migrationBuilder.RenameColumn(
                name: "BranchDescription",
                table: "CompanyBranches",
                newName: "BranchName");

            migrationBuilder.AddColumn<int>(
                name: "AddressID",
                table: "CompanyBranches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranches_AddressID",
                table: "CompanyBranches",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyBranches_Addresses_AddressID",
                table: "CompanyBranches",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
