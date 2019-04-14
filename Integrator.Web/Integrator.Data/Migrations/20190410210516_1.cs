using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Integrator.Data.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetailTypes",
                columns: table => new
                {
                    ContactDetailTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactDetailType = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetailTypes", x => x.ContactDetailTypeID);
                });

            migrationBuilder.CreateTable(
                name: "CoreKBIndustryTypes",
                columns: table => new
                {
                    IndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Industry = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKBIndustryTypes", x => x.IndustryID);
                });

            migrationBuilder.CreateTable(
                name: "EductaionalInstitutions",
                columns: table => new
                {
                    EductaionalInstitutionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EductaionalInstitution = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EductaionalInstitutions", x => x.EductaionalInstitutionID);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorFiles",
                columns: table => new
                {
                    FileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContentType = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    FileName = table.Column<string>(unicode: false, maxLength: 200, nullable: false),
                    FileExtension = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    FileSize = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorFiles", x => x.FileID);
                });

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
                name: "Interests",
                columns: table => new
                {
                    InterestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnInterest = table.Column<string>(unicode: false, maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.InterestID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Language = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "QualificationLevels",
                columns: table => new
                {
                    QualificationLevelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    QualificationLevel = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualificationLevels", x => x.QualificationLevelID);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    ContactDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactDetailTypeID = table.Column<int>(nullable: false),
                    ContactItem = table.Column<string>(unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.ContactDetailID);
                    table.ForeignKey(
                        name: "FK_ContactDetails_ContactDetailTypes",
                        column: x => x.ContactDetailTypeID,
                        principalTable: "ContactDetailTypes",
                        principalColumn: "ContactDetailTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyIndustries",
                columns: table => new
                {
                    CompanyIndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyID = table.Column<int>(nullable: false),
                    CoreKBIndustryID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyIndustries", x => x.CompanyIndustryID);
                    table.ForeignKey(
                        name: "FK_CompanyIndustries_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyIndustries_Industries",
                        column: x => x.CoreKBIndustryID,
                        principalTable: "CoreKBIndustryTypes",
                        principalColumn: "IndustryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreKBIndustryCategories",
                columns: table => new
                {
                    IndustryCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(maxLength: 100, nullable: true),
                    IndustryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKBIndustryCategories", x => x.IndustryCategoryID);
                    table.ForeignKey(
                        name: "FK_IndustryCategories_Industries",
                        column: x => x.IndustryID,
                        principalTable: "CoreKBIndustryTypes",
                        principalColumn: "IndustryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InegratorFileBlobs",
                columns: table => new
                {
                    FileID = table.Column<int>(nullable: false),
                    FileBlob = table.Column<byte[]>(type: "image", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InegratorFileBlobs", x => x.FileID);
                    table.ForeignKey(
                        name: "FK_InegratorFileBlobs_IntegratorFiles",
                        column: x => x.FileID,
                        principalTable: "IntegratorFiles",
                        principalColumn: "FileID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Suburb = table.Column<string>(nullable: true),
                    AreaCode = table.Column<string>(nullable: true),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    CountryID = table.Column<int>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    AddressType = table.Column<int>(nullable: false),
                    ComplexName = table.Column<string>(nullable: true),
                    ComplexUnitNumber = table.Column<string>(nullable: true),
                    POBoxNumber = table.Column<string>(nullable: true),
                    StreetNumber = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_Addresses_IntegratorUsers_IntegratorUserID",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumViteas",
                columns: table => new
                {
                    CurriculumViteaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: false),
                    CareerSummary = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumViteas", x => x.CurriculumViteaID);
                    table.ForeignKey(
                        name: "FK_CurriculumViteas_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserAwards",
                columns: table => new
                {
                    IntegratorUserAwardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    AwardTitle = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    AwardDescription = table.Column<string>(unicode: false, maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserAwards", x => x.IntegratorUserAwardID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserAwards_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IntegratorUserIndustries",
                columns: table => new
                {
                    IntegratorUserIndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    CoreKBIndustryID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserIndustries", x => x.IntegratorUserIndustryID);
                    table.ForeignKey(
                        name: "FK_UserIndustries_Industries",
                        column: x => x.CoreKBIndustryID,
                        principalTable: "CoreKBIndustryTypes",
                        principalColumn: "IndustryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserIndustries_Users",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "UserFiles",
                columns: table => new
                {
                    UserFileID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FileID = table.Column<int>(nullable: false),
                    IntegratorUserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFiles", x => x.UserFileID);
                    table.ForeignKey(
                        name: "FK_UserFiles_IntegratorFiles",
                        column: x => x.FileID,
                        principalTable: "IntegratorFiles",
                        principalColumn: "FileID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFiles_Users",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserPictures",
                columns: table => new
                {
                    FileID = table.Column<int>(nullable: false),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    IsCurrentProfilePicture = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPictures", x => x.FileID);
                    table.ForeignKey(
                        name: "FK_UserPictures_IntegratorFiles",
                        column: x => x.FileID,
                        principalTable: "IntegratorFiles",
                        principalColumn: "FileID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPicture_Users",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserInterests",
                columns: table => new
                {
                    IntegratorUserInterestID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    InterestID = table.Column<int>(nullable: false),
                    InterestLevel = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserInterests", x => x.IntegratorUserInterestID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserInterests_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserInterests_Interests",
                        column: x => x.InterestID,
                        principalTable: "Interests",
                        principalColumn: "InterestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserLanguages",
                columns: table => new
                {
                    IntegratorUserLanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    LanguageID = table.Column<int>(nullable: false),
                    IsPrimaryLanguage = table.Column<bool>(nullable: false),
                    CanSpeakAndWrite = table.Column<bool>(nullable: false),
                    LanguageProficiencyLevel = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserLanguages", x => x.IntegratorUserLanguageID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserLanguages_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserLanguages_Languages",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserQualifications",
                columns: table => new
                {
                    UserQualificationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    EductaionalInstitutionID = table.Column<int>(nullable: false),
                    QualificationLevelID = table.Column<int>(nullable: false),
                    QualificationTitle = table.Column<string>(unicode: false, maxLength: 175, nullable: false),
                    YearStartedQualification = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    YearCompletedQualification = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    QualificationAverage = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQualifications", x => x.UserQualificationID);
                    table.ForeignKey(
                        name: "FK_UserQualifications_EductaionalInstitutions",
                        column: x => x.EductaionalInstitutionID,
                        principalTable: "EductaionalInstitutions",
                        principalColumn: "EductaionalInstitutionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserQualifications_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserQualifications_QualificationLevels",
                        column: x => x.QualificationLevelID,
                        principalTable: "QualificationLevels",
                        principalColumn: "QualificationLevelID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserContactDetails",
                columns: table => new
                {
                    IntegratorUserContactDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    ContactDetailID = table.Column<int>(nullable: false),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserContactDetails", x => x.IntegratorUserContactDetailID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserContactDetails_ContactDetails",
                        column: x => x.ContactDetailID,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserContactDetails_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyIndustryCategories",
                columns: table => new
                {
                    CompanyIndustryCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyID = table.Column<int>(nullable: false),
                    CoreKBIndustryCategoryID = table.Column<int>(nullable: false),
                    CompanyIndustryID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyIndustryCategories", x => x.CompanyIndustryCategoryID);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategories_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategories_CompanyIndustries",
                        column: x => x.CompanyIndustryID,
                        principalTable: "CompanyIndustries",
                        principalColumn: "CompanyIndustryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategories_IndustryCategories",
                        column: x => x.CoreKBIndustryCategoryID,
                        principalTable: "CoreKBIndustryCategories",
                        principalColumn: "IndustryCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreKBIndustryCategoryJobs",
                columns: table => new
                {
                    IndustryCategoryJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IndustryCategoryID = table.Column<int>(nullable: false),
                    JobTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKBIndustryCategoryJobs", x => x.IndustryCategoryJobID);
                    table.ForeignKey(
                        name: "FK_IndustryCategoryJobs_IndustryCategories",
                        column: x => x.IndustryCategoryID,
                        principalTable: "CoreKBIndustryCategories",
                        principalColumn: "IndustryCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserIndustryCategories",
                columns: table => new
                {
                    IntegratorUserIndustryCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    IntegratorUserIndustryID = table.Column<int>(nullable: false),
                    CoreKBIndustryCategoryID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserIndustryCategories", x => x.IntegratorUserIndustryCategoryID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategories_IndustryCategories",
                        column: x => x.CoreKBIndustryCategoryID,
                        principalTable: "CoreKBIndustryCategories",
                        principalColumn: "IndustryCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategories_Users",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategories_UserIndustries",
                        column: x => x.IntegratorUserIndustryID,
                        principalTable: "IntegratorUserIndustries",
                        principalColumn: "IntegratorUserIndustryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyIndustryCategoryJobs",
                columns: table => new
                {
                    CompanyIndustryCategoryJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyID = table.Column<int>(nullable: false),
                    CompanyIndustryCategoryID = table.Column<int>(nullable: false),
                    CoreKBIndustryCategoryJobID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyIndustryCategoryJobs", x => x.CompanyIndustryCategoryJobID);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategoryJobs_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategoryJobs_CompanyIndustryCategories",
                        column: x => x.CompanyIndustryCategoryID,
                        principalTable: "CompanyIndustryCategories",
                        principalColumn: "CompanyIndustryCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategoryJobs_IndustryCategoryJobs",
                        column: x => x.CoreKBIndustryCategoryJobID,
                        principalTable: "CoreKBIndustryCategoryJobs",
                        principalColumn: "IndustryCategoryJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreKBIndustryCategoryJobSkillSets",
                columns: table => new
                {
                    IndustryCategorySkillSetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IndustryCategoryJobID = table.Column<int>(nullable: false),
                    IndustryCategorySkillSet = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKBIndustryCategoryJobSkillSets", x => x.IndustryCategorySkillSetID);
                    table.ForeignKey(
                        name: "FK_IndustryCategorySkillSets_IndustryCategoryJobs",
                        column: x => x.IndustryCategoryJobID,
                        principalTable: "CoreKBIndustryCategoryJobs",
                        principalColumn: "IndustryCategoryJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserIndustryCategoryJobs",
                columns: table => new
                {
                    IntegratorUserIndustryCategoryJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    IntegratorUserIndustryCategoryID = table.Column<int>(nullable: false),
                    CoreKBIndustryCategoryJobID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsPrimaryJobFunction = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserIndustryCategoryJobs", x => x.IntegratorUserIndustryCategoryJobID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategoryJobs_IndustryCategoryJobs",
                        column: x => x.CoreKBIndustryCategoryJobID,
                        principalTable: "CoreKBIndustryCategoryJobs",
                        principalColumn: "IndustryCategoryJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategoryJobs_Users",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategoryJobs_IntegratorUserIndustryCategories",
                        column: x => x.IntegratorUserIndustryCategoryID,
                        principalTable: "IntegratorUserIndustryCategories",
                        principalColumn: "IntegratorUserIndustryCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyIndustryCategoryJobSkillSets",
                columns: table => new
                {
                    CompanyIndustryCategoryJobSkillSetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyID = table.Column<int>(nullable: false),
                    CompanyIndustryCategoryJobID = table.Column<int>(nullable: false),
                    CoreKBIndustryCategorySkillSetID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyIndustryCategoryJobSkillSets", x => x.CompanyIndustryCategoryJobSkillSetID);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategoryJobSkillSets_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategoryJobSkillSets_CompanyIndustryCategoryJobs",
                        column: x => x.CompanyIndustryCategoryJobID,
                        principalTable: "CompanyIndustryCategoryJobs",
                        principalColumn: "CompanyIndustryCategoryJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyIndustryCategoryJobSkillSets_IndustryCategorySkillSets",
                        column: x => x.CoreKBIndustryCategorySkillSetID,
                        principalTable: "CoreKBIndustryCategoryJobSkillSets",
                        principalColumn: "IndustryCategorySkillSetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumViteaWorkExperiences",
                columns: table => new
                {
                    CurriculumViteaWorkExperienceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurriculumViteaID = table.Column<int>(nullable: false),
                    IntegratorUserIndustryCategoryJobID = table.Column<int>(nullable: false),
                    DateStarted = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    DateEnded = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    CompanyID = table.Column<int>(nullable: false),
                    Achievments = table.Column<string>(unicode: false, nullable: false, defaultValueSql: "('')"),
                    WorkExperienceDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumViteaWorkExperiences", x => x.CurriculumViteaWorkExperienceID);
                    table.ForeignKey(
                        name: "FK_CurriculumViteaWorkExperiences_Company",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserWorkExperienceHistory_CurriculumViteas",
                        column: x => x.CurriculumViteaID,
                        principalTable: "CurriculumViteas",
                        principalColumn: "CurriculumViteaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UseEmploymentHistory_IntegratorUserIndustryCategoryJobs",
                        column: x => x.IntegratorUserIndustryCategoryJobID,
                        principalTable: "IntegratorUserIndustryCategoryJobs",
                        principalColumn: "IntegratorUserIndustryCategoryJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IntegratorUserIndustryCategoryJobSkillSets",
                columns: table => new
                {
                    IntegratorUserIndustryCategoryJobSkillSetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    IntegratorUserIndustryCategoryJobID = table.Column<int>(nullable: false),
                    CoreKBIndustryCategorySkillSetID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 1000, nullable: true),
                    DateLastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    SkillLevel = table.Column<decimal>(type: "numeric(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntegratorUserIndustryCategoryJobSkillSets", x => x.IntegratorUserIndustryCategoryJobSkillSetID);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategoryJobSkillSets_IndustryCategorySkillSets",
                        column: x => x.CoreKBIndustryCategorySkillSetID,
                        principalTable: "CoreKBIndustryCategoryJobSkillSets",
                        principalColumn: "IndustryCategorySkillSetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategoryJobSkillSets_Users",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserIndustryCategoryJobs",
                        column: x => x.IntegratorUserIndustryCategoryJobID,
                        principalTable: "IntegratorUserIndustryCategoryJobs",
                        principalColumn: "IntegratorUserIndustryCategoryJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumVitaeWorkExperienceReferences",
                columns: table => new
                {
                    CurriculumVitaeWorkExperienceReferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurriculumViteaWorkExperienceID = table.Column<int>(nullable: false),
                    ContactFirstName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    ContactLastName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    HasBeenVerified = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumVitaeWorkExperienceReferences", x => x.CurriculumVitaeWorkExperienceReferenceID);
                    table.ForeignKey(
                        name: "FK_CurriculumVitaeWorkExperienceReferences_CurriculumViteaWorkExperiences",
                        column: x => x.CurriculumViteaWorkExperienceID,
                        principalTable: "CurriculumViteaWorkExperiences",
                        principalColumn: "CurriculumViteaWorkExperienceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurriculumViteaWorkExperienceSkillSets",
                columns: table => new
                {
                    CurriculumViteaWorkExperienceSkillSetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurriculumViteaWorkExperienceID = table.Column<int>(nullable: false),
                    IntegratorUserIndustryCategoryJobSkillSetID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurriculumViteaWorkExperienceSkillSets", x => x.CurriculumViteaWorkExperienceSkillSetID);
                    table.ForeignKey(
                        name: "FK_CurriculumViteaWorkExperienceSkillSets_CurriculumViteaWorkExperiences",
                        column: x => x.CurriculumViteaWorkExperienceID,
                        principalTable: "CurriculumViteaWorkExperiences",
                        principalColumn: "CurriculumViteaWorkExperienceID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CurriculumViteaWorkExperienceSkillSets_IntegratorUserIndustryCategoryJobSkillSets",
                        column: x => x.IntegratorUserIndustryCategoryJobSkillSetID,
                        principalTable: "IntegratorUserIndustryCategoryJobSkillSets",
                        principalColumn: "IntegratorUserIndustryCategoryJobSkillSetID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkExperienceReferenceContactDetails",
                columns: table => new
                {
                    WorkExperienceReferenceContactDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactDetailID = table.Column<int>(nullable: false),
                    CurriculumVitaeWorkExperienceReferenceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperienceReferenceContactDetails", x => x.WorkExperienceReferenceContactDetailID);
                    table.ForeignKey(
                        name: "FK_WorkExperienceReferenceContactDetails_ContactDetails",
                        column: x => x.ContactDetailID,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkExperienceReferenceContactDetails_CurriculumVitaeWorkExperienceReferences",
                        column: x => x.CurriculumVitaeWorkExperienceReferenceID,
                        principalTable: "CurriculumVitaeWorkExperienceReferences",
                        principalColumn: "CurriculumVitaeWorkExperienceReferenceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyID", "CompanyName" },
                values: new object[] { 1, "Self Employed" });

            migrationBuilder.InsertData(
                table: "ContactDetailTypes",
                columns: new[] { "ContactDetailTypeID", "ContactDetailType" },
                values: new object[,]
                {
                    { 1, "Cell Number" },
                    { 2, "Office Number" },
                    { 3, "Email Address" },
                    { 4, "WebSite" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestID", "AnInterest" },
                values: new object[,]
                {
                    { 1, "Climbing" },
                    { 2, "Snowboarding" },
                    { 3, "Cooking" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageID", "Language" },
                values: new object[,]
                {
                    { 4, "Zulu" },
                    { 3, "Xhosa" },
                    { 1, "English" },
                    { 2, "Afrikaans" }
                });

            migrationBuilder.InsertData(
                table: "QualificationLevels",
                columns: new[] { "QualificationLevelID", "QualificationLevel" },
                values: new object[,]
                {
                    { 5, "Certificate" },
                    { 1, "Masters Degree" },
                    { 2, "Honours Degree" },
                    { 3, "Degree" },
                    { 4, "Doctorial Degree" },
                    { 6, "Shool Level Equivalent" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_IntegratorUserID",
                table: "Addresses",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustries_CompanyID",
                table: "CompanyIndustries",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustries_CoreKBIndustryID",
                table: "CompanyIndustries",
                column: "CoreKBIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategories_CompanyID",
                table: "CompanyIndustryCategories",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategories_CompanyIndustryID",
                table: "CompanyIndustryCategories",
                column: "CompanyIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategories_CoreKBIndustryCategoryID",
                table: "CompanyIndustryCategories",
                column: "CoreKBIndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategoryJobs_CompanyID",
                table: "CompanyIndustryCategoryJobs",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategoryJobs_CompanyIndustryCategoryID",
                table: "CompanyIndustryCategoryJobs",
                column: "CompanyIndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategoryJobs_CoreKBIndustryCategoryJobID",
                table: "CompanyIndustryCategoryJobs",
                column: "CoreKBIndustryCategoryJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategoryJobSkillSets_CompanyID",
                table: "CompanyIndustryCategoryJobSkillSets",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategoryJobSkillSets_CompanyIndustryCategoryJobID",
                table: "CompanyIndustryCategoryJobSkillSets",
                column: "CompanyIndustryCategoryJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyIndustryCategoryJobSkillSets_CoreKBIndustryCategorySkillSetID",
                table: "CompanyIndustryCategoryJobSkillSets",
                column: "CoreKBIndustryCategorySkillSetID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_ContactDetailTypeID",
                table: "ContactDetails",
                column: "ContactDetailTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKBIndustryCategories_IndustryID",
                table: "CoreKBIndustryCategories",
                column: "IndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKBIndustryCategoryJobs_IndustryCategoryID",
                table: "CoreKBIndustryCategoryJobs",
                column: "IndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKBIndustryCategoryJobSkillSets_IndustryCategoryJobID",
                table: "CoreKBIndustryCategoryJobSkillSets",
                column: "IndustryCategoryJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumVitaeWorkExperienceReferences_CurriculumViteaWorkExperienceID",
                table: "CurriculumVitaeWorkExperienceReferences",
                column: "CurriculumViteaWorkExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumViteas_IntegratorUserID",
                table: "CurriculumViteas",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumViteaWorkExperiences_CompanyID",
                table: "CurriculumViteaWorkExperiences",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumViteaWorkExperiences_CurriculumViteaID",
                table: "CurriculumViteaWorkExperiences",
                column: "CurriculumViteaID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumViteaWorkExperiences_IntegratorUserIndustryCategoryJobID",
                table: "CurriculumViteaWorkExperiences",
                column: "IntegratorUserIndustryCategoryJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumViteaWorkExperienceSkillSets_CurriculumViteaWorkExperienceID",
                table: "CurriculumViteaWorkExperienceSkillSets",
                column: "CurriculumViteaWorkExperienceID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumViteaWorkExperienceSkillSets_IntegratorUserIndustryCategoryJobSkillSetID",
                table: "CurriculumViteaWorkExperienceSkillSets",
                column: "IntegratorUserIndustryCategoryJobSkillSetID");

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
                name: "IX_IntegratorUserAwards_IntegratorUserID",
                table: "IntegratorUserAwards",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserClaims_IntegratorUserID",
                table: "IntegratorUserClaims",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserContactDetails_ContactDetailID",
                table: "IntegratorUserContactDetails",
                column: "ContactDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserContactDetails_IntegratorUserID",
                table: "IntegratorUserContactDetails",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustries_CoreKBIndustryID",
                table: "IntegratorUserIndustries",
                column: "CoreKBIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustries_IntegratorUserID",
                table: "IntegratorUserIndustries",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategories_CoreKBIndustryCategoryID",
                table: "IntegratorUserIndustryCategories",
                column: "CoreKBIndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategories_IntegratorUserID",
                table: "IntegratorUserIndustryCategories",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategories_IntegratorUserIndustryID",
                table: "IntegratorUserIndustryCategories",
                column: "IntegratorUserIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategoryJobs_CoreKBIndustryCategoryJobID",
                table: "IntegratorUserIndustryCategoryJobs",
                column: "CoreKBIndustryCategoryJobID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategoryJobs_IntegratorUserID",
                table: "IntegratorUserIndustryCategoryJobs",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategoryJobs_IntegratorUserIndustryCategoryID",
                table: "IntegratorUserIndustryCategoryJobs",
                column: "IntegratorUserIndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategoryJobSkillSets_CoreKBIndustryCategorySkillSetID",
                table: "IntegratorUserIndustryCategoryJobSkillSets",
                column: "CoreKBIndustryCategorySkillSetID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserID",
                table: "IntegratorUserIndustryCategoryJobSkillSets",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserIndustryCategoryJobSkillSets_IntegratorUserIndustryCategoryJobID",
                table: "IntegratorUserIndustryCategoryJobSkillSets",
                column: "IntegratorUserIndustryCategoryJobID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserInterests_IntegratorUserID",
                table: "IntegratorUserInterests",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserInterests_InterestID",
                table: "IntegratorUserInterests",
                column: "InterestID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserLanguages_IntegratorUserID",
                table: "IntegratorUserLanguages",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IntegratorUserLanguages_LanguageID",
                table: "IntegratorUserLanguages",
                column: "LanguageID");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserFiles_FileID",
                table: "UserFiles",
                column: "FileID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFiles_IntegratorUserID",
                table: "UserFiles",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPictures_IntegratorUserID",
                table: "UserPictures",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserQualifications_EductaionalInstitutionID",
                table: "UserQualifications",
                column: "EductaionalInstitutionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserQualifications_IntegratorUserID",
                table: "UserQualifications",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserQualifications_QualificationLevelID",
                table: "UserQualifications",
                column: "QualificationLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperienceReferenceContactDetails_ContactDetailID",
                table: "WorkExperienceReferenceContactDetails",
                column: "ContactDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperienceReferenceContactDetails_CurriculumVitaeWorkExperienceReferenceID",
                table: "WorkExperienceReferenceContactDetails",
                column: "CurriculumVitaeWorkExperienceReferenceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CompanyIndustryCategoryJobSkillSets");

            migrationBuilder.DropTable(
                name: "CurriculumViteaWorkExperienceSkillSets");

            migrationBuilder.DropTable(
                name: "InegratorFileBlobs");

            migrationBuilder.DropTable(
                name: "IntegratorRoleClaims");

            migrationBuilder.DropTable(
                name: "IntegratorUserAwards");

            migrationBuilder.DropTable(
                name: "IntegratorUserClaims");

            migrationBuilder.DropTable(
                name: "IntegratorUserContactDetails");

            migrationBuilder.DropTable(
                name: "IntegratorUserInterests");

            migrationBuilder.DropTable(
                name: "IntegratorUserLanguages");

            migrationBuilder.DropTable(
                name: "IntegratorUserLogins");

            migrationBuilder.DropTable(
                name: "IntegratorUserRoles");

            migrationBuilder.DropTable(
                name: "IntegratorUserTokens");

            migrationBuilder.DropTable(
                name: "UserFiles");

            migrationBuilder.DropTable(
                name: "UserPictures");

            migrationBuilder.DropTable(
                name: "UserQualifications");

            migrationBuilder.DropTable(
                name: "WorkExperienceReferenceContactDetails");

            migrationBuilder.DropTable(
                name: "CompanyIndustryCategoryJobs");

            migrationBuilder.DropTable(
                name: "IntegratorUserIndustryCategoryJobSkillSets");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "IntegratorRoles");

            migrationBuilder.DropTable(
                name: "IntegratorFiles");

            migrationBuilder.DropTable(
                name: "EductaionalInstitutions");

            migrationBuilder.DropTable(
                name: "QualificationLevels");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "CurriculumVitaeWorkExperienceReferences");

            migrationBuilder.DropTable(
                name: "CompanyIndustryCategories");

            migrationBuilder.DropTable(
                name: "CoreKBIndustryCategoryJobSkillSets");

            migrationBuilder.DropTable(
                name: "ContactDetailTypes");

            migrationBuilder.DropTable(
                name: "CurriculumViteaWorkExperiences");

            migrationBuilder.DropTable(
                name: "CompanyIndustries");

            migrationBuilder.DropTable(
                name: "CurriculumViteas");

            migrationBuilder.DropTable(
                name: "IntegratorUserIndustryCategoryJobs");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "CoreKBIndustryCategoryJobs");

            migrationBuilder.DropTable(
                name: "IntegratorUserIndustryCategories");

            migrationBuilder.DropTable(
                name: "CoreKBIndustryCategories");

            migrationBuilder.DropTable(
                name: "IntegratorUserIndustries");

            migrationBuilder.DropTable(
                name: "CoreKBIndustryTypes");

            migrationBuilder.DropTable(
                name: "IntegratorUsers");
        }
    }
}
