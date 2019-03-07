using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IntegratorRoles",
                columns: table => new
                {
                    IntegratorRoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorRoles", x => x.IntegratorRoleID);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUsers",
                columns: table => new
                {
                    IntegratorUserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUsers", x => x.IntegratorUserID);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorRoleClaims",
                columns: table => new
                {
                    IntegratorRoleClaimID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BIntegratorRoleID = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorRoleClaims", x => x.IntegratorRoleClaimID);
                    table.ForeignKey(
                        name: "FK_IntegratorRoleClaims_IntegratorRoles_BIntegratorRoleID",
                        column: x => x.BIntegratorRoleID,
                        principalTable: "IntegratorRoles",
                        principalColumn: "IntegratorRoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserClaims",
                columns: table => new
                {
                    IntegratorUserClaimID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserClaims", x => x.IntegratorUserClaimID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserClaims_IntegratorUsers_IntegratorUserID",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    IntegratorUserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_IntegratorUserLogins_IntegratorUsers_IntegratorUserID",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserRoles",
                columns: table => new
                {
                    IntegratorUserID = table.Column<int>(nullable: false),
                    IntegratorRoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserRoles", x => new { x.IntegratorUserID, x.IntegratorRoleID });
                    table.ForeignKey(
                        name: "FK_IntegratorUserRoles_IntegratorRoles_IntegratorRoleID",
                        column: x => x.IntegratorRoleID,
                        principalTable: "IntegratorRoles",
                        principalColumn: "IntegratorRoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IntegratorUserRoles_IntegratorUsers_IntegratorUserID",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserTokens",
                columns: table => new
                {
                    IntegratorUserID = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserTokens", x => new { x.IntegratorUserID, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_IntegratorUserTokens_IntegratorUsers_IntegratorUserID",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorRoleClaims_BIntegratorRoleID",
                table: "IntegratorRoleClaims",
                column: "BIntegratorRoleID");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "IntegratorRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserClaims_IntegratorUserID",
                table: "IntegratorUserClaims",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserLogins_IntegratorUserID",
                table: "IntegratorUserLogins",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserRoles_IntegratorRoleID",
                table: "IntegratorUserRoles",
                column: "IntegratorRoleID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "IntegratorUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "IntegratorUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntegratorRoleClaims");

            migrationBuilder.DropTable(
                name: "IntegratorUserClaims");

            migrationBuilder.DropTable(
                name: "IntegratorUserLogins");

            migrationBuilder.DropTable(
                name: "IntegratorUserRoles");

            migrationBuilder.DropTable(
                name: "IntegratorUserTokens");

            migrationBuilder.DropTable(
                name: "IntegratorRoles");

            migrationBuilder.DropTable(
                name: "IntegratorUsers");
        }
    }
}
