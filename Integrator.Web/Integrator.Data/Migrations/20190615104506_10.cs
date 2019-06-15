using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_IntegratorUsers_IntegratorUserID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Suburb",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "IntegratorUserID",
                table: "Addresses",
                newName: "SuburbID");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_IntegratorUserID",
                table: "Addresses",
                newName: "IX_Addresses_SuburbID");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Addresses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AgentAreas",
                columns: table => new
                {
                    AgentAreaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SuburbID = table.Column<int>(nullable: false),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    DateAssigned = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentAreas", x => x.AgentAreaID);
                    table.ForeignKey(
                        name: "FK_AgentAreas_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AgentAreas_Suburbs",
                        column: x => x.SuburbID,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndividualAddresses",
                columns: table => new
                {
                    IndividualAddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressID = table.Column<int>(nullable: false),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualAddresses", x => x.IndividualAddressID);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_Addresses",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CustomerAddresses_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityID",
                table: "Addresses",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryID",
                table: "Addresses",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_AgentAreas_IntegratorUserID",
                table: "AgentAreas",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_AgentAreas_SuburbID",
                table: "AgentAreas",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAddresses_AddressID",
                table: "IndividualAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAddresses_IntegratorUserID",
                table: "IndividualAddresses",
                column: "IntegratorUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities",
                table: "Addresses",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Countries",
                table: "Addresses",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Suburbs",
                table: "Addresses",
                column: "SuburbID",
                principalTable: "Suburbs",
                principalColumn: "SuburbID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Countries",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Suburbs",
                table: "Addresses");

            migrationBuilder.DropTable(
                name: "AgentAreas");

            migrationBuilder.DropTable(
                name: "IndividualAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityID",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CountryID",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Addresses");

            migrationBuilder.RenameColumn(
                name: "SuburbID",
                table: "Addresses",
                newName: "IntegratorUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_SuburbID",
                table: "Addresses",
                newName: "IX_Addresses_IntegratorUserID");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Suburb",
                table: "Addresses",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_IntegratorUsers_IntegratorUserID",
                table: "Addresses",
                column: "IntegratorUserID",
                principalTable: "IntegratorUsers",
                principalColumn: "IntegratorUserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
