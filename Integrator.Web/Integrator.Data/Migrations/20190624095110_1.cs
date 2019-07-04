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
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
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
                name: "CoreKbIndustryCategories",
                columns: table => new
                {
                    CoreKbIndustryCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKBIndustryCategory = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbIndustryCategories", x => x.CoreKbIndustryCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "CoreKbJobs",
                columns: table => new
                {
                    CoreKbJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKBJob = table.Column<string>(unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbJobs", x => x.CoreKbJobID);
                });

            migrationBuilder.CreateTable(
                name: "CoreKbSkillTypes",
                columns: table => new
                {
                    CoreKbSkillTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKBSkillType = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbSkillTypes", x => x.CoreKbSkillTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CountryCode = table.Column<string>(unicode: false, maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
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
                    FileSize = table.Column<long>(nullable: false),
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
                    LanguageSpoken = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
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
                name: "CoreKbIndustries",
                columns: table => new
                {
                    CoreKbIndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKbIndustryCategoryID = table.Column<int>(nullable: false),
                    CoreKBIndustryName = table.Column<string>(unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbIndustries", x => x.CoreKbIndustryID);
                    table.ForeignKey(
                        name: "FK_CoreKbIndustrySectors_CoreKBIdustryCategories",
                        column: x => x.CoreKbIndustryCategoryID,
                        principalTable: "CoreKbIndustryCategories",
                        principalColumn: "CoreKbIndustryCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyJobs",
                columns: table => new
                {
                    CompanyJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKbJobID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    JobDescription = table.Column<string>(unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobs", x => x.CompanyJobID);
                    table.ForeignKey(
                        name: "FK_CompanyJobs_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyJobs_CoreKBJobs",
                        column: x => x.CoreKbJobID,
                        principalTable: "CoreKbJobs",
                        principalColumn: "CoreKbJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreSkillCategories",
                columns: table => new
                {
                    CoreSkillCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKbSkillTypeID = table.Column<int>(nullable: false),
                    CoreSkillCategoryName = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreSkillCategories", x => x.CoreSkillCategoryID);
                    table.ForeignKey(
                        name: "FK_CoreSkillCategories_CoreKBSkillTypes",
                        column: x => x.CoreKbSkillTypeID,
                        principalTable: "CoreKbSkillTypes",
                        principalColumn: "CoreKbSkillTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryID = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Cities_Countries",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
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

            migrationBuilder.CreateTable(
                name: "CompanyRelatedIndustries",
                columns: table => new
                {
                    CompanyRelatedIndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKbIndustryID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    LevelOfCompanyInvolvement = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRelatedIndustries", x => x.CompanyRelatedIndustryID);
                    table.ForeignKey(
                        name: "FK_CompanyRelatedIndustries_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyRelatedIndustries_CoreKbIndustries",
                        column: x => x.CoreKbIndustryID,
                        principalTable: "CoreKbIndustries",
                        principalColumn: "CoreKbIndustryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreKbIndustryJobs",
                columns: table => new
                {
                    CoreKbIndustryJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKbIndustryID = table.Column<int>(nullable: false),
                    CoreKbJobID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbIndustryJobs", x => x.CoreKbIndustryJobID);
                    table.ForeignKey(
                        name: "FK_CoreKBIndustrySectorJobs_CoreKbIndustrySectors",
                        column: x => x.CoreKbIndustryID,
                        principalTable: "CoreKbIndustries",
                        principalColumn: "CoreKbIndustryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreKBIndustrySectorJobs_CoreKBJobs",
                        column: x => x.CoreKbJobID,
                        principalTable: "CoreKbJobs",
                        principalColumn: "CoreKbJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyJobListings",
                columns: table => new
                {
                    CompanyJobListingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyJobID = table.Column<int>(nullable: false),
                    DateStarted = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    DateEnded = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    LevelOfUrgentcy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobListings", x => x.CompanyJobListingID);
                    table.ForeignKey(
                        name: "FK_CompanyJobListings_CompanyJobs",
                        column: x => x.CompanyJobID,
                        principalTable: "CompanyJobs",
                        principalColumn: "CompanyJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreKbSkills",
                columns: table => new
                {
                    CoreKbSkillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreSkillCategoryID = table.Column<int>(nullable: false),
                    CoreSkill = table.Column<string>(unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbSkills", x => x.CoreKbSkillID);
                    table.ForeignKey(
                        name: "FK_CoreKBSkills_CoreSkillCategories",
                        column: x => x.CoreSkillCategoryID,
                        principalTable: "CoreSkillCategories",
                        principalColumn: "CoreSkillCategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suburbs",
                columns: table => new
                {
                    SuburbID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityID = table.Column<int>(nullable: false),
                    SuburbName = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suburbs", x => x.SuburbID);
                    table.ForeignKey(
                        name: "FK_Suburbs_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "UserJobs",
                columns: table => new
                {
                    UserJobID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurriculumViteaID = table.Column<int>(nullable: false),
                    IntegratorUserID = table.Column<int>(nullable: false),
                    CoreKbJobID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    DateStarted = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    DateEnded = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "(getdate())"),
                    Achievments = table.Column<string>(unicode: false, nullable: true, defaultValueSql: "('')"),
                    WorkExperienceDescription = table.Column<string>(unicode: false, nullable: false),
                    IsCurrentJob = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserJobs", x => x.UserJobID);
                    table.ForeignKey(
                        name: "FK_UserJobs_Company",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_CoreKBJobs",
                        column: x => x.CoreKbJobID,
                        principalTable: "CoreKbJobs",
                        principalColumn: "CoreKbJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_CurriculumViteas",
                        column: x => x.CurriculumViteaID,
                        principalTable: "CurriculumViteas",
                        principalColumn: "CurriculumViteaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_IntegratorUsers",
                        column: x => x.IntegratorUserID,
                        principalTable: "IntegratorUsers",
                        principalColumn: "IntegratorUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyJobRelatedIndustries",
                columns: table => new
                {
                    CompanyJobRelatedIndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyRelatedIndustryID = table.Column<int>(nullable: false),
                    CompanyJobID = table.Column<int>(nullable: false),
                    LevelOfCompanyInvolvement = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobRelatedIndustries", x => x.CompanyJobRelatedIndustryID);
                    table.ForeignKey(
                        name: "FK_ComanyJobRelatedIndustries_CompanyJobs",
                        column: x => x.CompanyJobID,
                        principalTable: "CompanyJobs",
                        principalColumn: "CompanyJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyJobRelatedIndustries_CompanyRelatedIndustries",
                        column: x => x.CompanyRelatedIndustryID,
                        principalTable: "CompanyRelatedIndustries",
                        principalColumn: "CompanyRelatedIndustryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyJobSkills",
                columns: table => new
                {
                    CompanyJobSkillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyJobID = table.Column<int>(nullable: false),
                    CoreKbSkillID = table.Column<int>(nullable: false),
                    LevelOfImportantce = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobSkills", x => x.CompanyJobSkillID);
                    table.ForeignKey(
                        name: "FK_CompanyJobSkills_CompanyJobs",
                        column: x => x.CompanyJobID,
                        principalTable: "CompanyJobs",
                        principalColumn: "CompanyJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyJobSkills_CoreKBSkills",
                        column: x => x.CoreKbSkillID,
                        principalTable: "CoreKbSkills",
                        principalColumn: "CoreKbSkillID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CoreKbJobSkills",
                columns: table => new
                {
                    CoreKbJobSkillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoreKbJobID = table.Column<int>(nullable: false),
                    CoreKbSkillID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoreKbJobSkills", x => x.CoreKbJobSkillID);
                    table.ForeignKey(
                        name: "FK_CoreKBJobSkills_CoreKBJobs",
                        column: x => x.CoreKbJobID,
                        principalTable: "CoreKbJobs",
                        principalColumn: "CoreKbJobID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CoreKBJobSoftSkills_CoreSoftSkills",
                        column: x => x.CoreKbSkillID,
                        principalTable: "CoreKbSkills",
                        principalColumn: "CoreKbSkillID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryID = table.Column<int>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    SuburbID = table.Column<int>(nullable: false),
                    AreaCode = table.Column<string>(nullable: true),
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
                        name: "FK_Addresses_Cities",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Countries",
                        column: x => x.CountryID,
                        principalTable: "Countries",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Addresses_Suburbs",
                        column: x => x.SuburbID,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "UserJobRelatedIndustries",
                columns: table => new
                {
                    UserJobRelatedIndustryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserJobID = table.Column<int>(nullable: false),
                    CoreKbIndustryID = table.Column<int>(nullable: false),
                    LevelOfIndustryInvolvement = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserJobRelatedIndustries", x => x.UserJobRelatedIndustryID);
                    table.ForeignKey(
                        name: "FK_UserJobRelatedIndustries_CoreKbIndustries",
                        column: x => x.CoreKbIndustryID,
                        principalTable: "CoreKbIndustries",
                        principalColumn: "CoreKbIndustryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobRelatedIndustries_UserJobs",
                        column: x => x.UserJobID,
                        principalTable: "UserJobs",
                        principalColumn: "UserJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserJobSkills",
                columns: table => new
                {
                    UserJobSkillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserJobID = table.Column<int>(nullable: false),
                    CoreKbSkillID = table.Column<int>(nullable: false),
                    UserJobSkillLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserJobSkills", x => x.UserJobSkillID);
                    table.ForeignKey(
                        name: "FK_UserJobSkills_CoreKBSkills",
                        column: x => x.CoreKbSkillID,
                        principalTable: "CoreKbSkills",
                        principalColumn: "CoreKbSkillID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserJobSkills_UserJobs",
                        column: x => x.UserJobID,
                        principalTable: "UserJobs",
                        principalColumn: "UserJobID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyBranches",
                columns: table => new
                {
                    CompanyBranchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressID = table.Column<int>(nullable: false),
                    CompanyID = table.Column<int>(nullable: false),
                    BranchName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyBranches", x => x.CompanyBranchID);
                    table.ForeignKey(
                        name: "FK_CompanyBranches_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyAddresses_Companies",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
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

            migrationBuilder.CreateTable(
                name: "CompanyContactDetails",
                columns: table => new
                {
                    CompanyContactDetailID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactDetailID = table.Column<int>(nullable: false),
                    CompanyBranchID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContactDetails", x => x.CompanyContactDetailID);
                    table.ForeignKey(
                        name: "FK_CompanyContactDetails_CompanyBranches",
                        column: x => x.CompanyBranchID,
                        principalTable: "CompanyBranches",
                        principalColumn: "CompanyBranchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyContactDetails_ContactDetails",
                        column: x => x.ContactDetailID,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactDetailID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyJobAssociatedBranches",
                columns: table => new
                {
                    CompanyJobAssociatedBranchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyJobID = table.Column<int>(nullable: false),
                    CompanyBranchID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyJobAssociatedBranches", x => x.CompanyJobAssociatedBranchID);
                    table.ForeignKey(
                        name: "FK_CompanyJobAssociatedBranches_CompanyBranches",
                        column: x => x.CompanyBranchID,
                        principalTable: "CompanyBranches",
                        principalColumn: "CompanyBranchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyJobAssociatedBranches_CompanyJobs",
                        column: x => x.CompanyJobID,
                        principalTable: "CompanyJobs",
                        principalColumn: "CompanyJobID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyRepresentiveBranches",
                columns: table => new
                {
                    CompanyRepresentiveBranchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyBranchID = table.Column<int>(nullable: false),
                    CompanyRepresentativeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyRepresentiveBranches", x => x.CompanyRepresentiveBranchID);
                    table.ForeignKey(
                        name: "FK_CompnayRepresentiveBanches_CompanyBranches",
                        column: x => x.CompanyBranchID,
                        principalTable: "CompanyBranches",
                        principalColumn: "CompanyBranchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompnayRepresentiveBanches_CompanyRepresentatives",
                        column: x => x.CompanyRepresentativeID,
                        principalTable: "CompanyRepresentatives",
                        principalColumn: "CompanyRepresentativeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Companies",
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
                table: "CoreKbIndustryCategories",
                columns: new[] { "CoreKbIndustryCategoryID", "CoreKBIndustryCategory" },
                values: new object[,]
                {
                    { 6, "Energy and Utilities" },
                    { 5, "Education" },
                    { 4, "Consumer Services" },
                    { 3, "Education" },
                    { 2, "Business Services" },
                    { 1, "Agriculture and Mining" }
                });

            migrationBuilder.InsertData(
                table: "CoreKbSkillTypes",
                columns: new[] { "CoreKbSkillTypeID", "CoreKBSkillType" },
                values: new object[,]
                {
                    { 1, "HardSkill" },
                    { 2, "SoftSkill" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "InterestID", "AnInterest" },
                values: new object[,]
                {
                    { 3, "Cooking" },
                    { 2, "Snowboarding" },
                    { 1, "Climbing" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageID", "LanguageSpoken" },
                values: new object[,]
                {
                    { 3, "Xhosa" },
                    { 2, "Afrikaans" },
                    { 1, "English" },
                    { 4, "Zulu" }
                });

            migrationBuilder.InsertData(
                table: "QualificationLevels",
                columns: new[] { "QualificationLevelID", "QualificationLevel" },
                values: new object[,]
                {
                    { 2, "Honours Degree" },
                    { 3, "Degree" },
                    { 4, "Doctorial Degree" },
                    { 5, "Certificate" },
                    { 6, "Shool Level Equivalent" },
                    { 1, "Masters Degree" }
                });

            migrationBuilder.InsertData(
                table: "CoreKbIndustries",
                columns: new[] { "CoreKbIndustryID", "CoreKbIndustryCategoryID", "CoreKBIndustryName" },
                values: new object[,]
                {
                    { 1, 1, "Farming and Ranching" },
                    { 2, 1, "Fishing" },
                    { 3, 1, "Hunting " },
                    { 4, 1, "Forestry" },
                    { 5, 1, "Mining and Quarrying" }
                });

            migrationBuilder.InsertData(
                table: "CoreSkillCategories",
                columns: new[] { "CoreSkillCategoryID", "CoreKbSkillTypeID", "CoreSkillCategoryName" },
                values: new object[,]
                {
                    { 1, 2, "Communication" },
                    { 2, 2, "Leadership" },
                    { 3, 2, "Influencing" },
                    { 4, 2, "Creativity" },
                    { 5, 2, "Professional" },
                    { 6, 2, "Interpersonal" },
                    { 7, 2, "Personal" }
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
                name: "IX_Addresses_SuburbID",
                table: "Addresses",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_AgentAreas_IntegratorUserID",
                table: "AgentAreas",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_AgentAreas_SuburbID",
                table: "AgentAreas",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryID",
                table: "Cities",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranches_AddressID",
                table: "CompanyBranches",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyBranches_CompanyID",
                table: "CompanyBranches",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContactDetails_CompanyBranchID",
                table: "CompanyContactDetails",
                column: "CompanyBranchID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContactDetails_ContactDetailID",
                table: "CompanyContactDetails",
                column: "ContactDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobAssociatedBranches_CompanyBranchID",
                table: "CompanyJobAssociatedBranches",
                column: "CompanyBranchID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobAssociatedBranches_CompanyJobID",
                table: "CompanyJobAssociatedBranches",
                column: "CompanyJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobListings_CompanyJobID",
                table: "CompanyJobListings",
                column: "CompanyJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRelatedIndustries_CompanyJobID",
                table: "CompanyJobRelatedIndustries",
                column: "CompanyJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRelatedIndustries_CompanyRelatedIndustryID",
                table: "CompanyJobRelatedIndustries",
                column: "CompanyRelatedIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRepresentitives_CompanyJobID",
                table: "CompanyJobRepresentitives",
                column: "CompanyJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobRepresentitives_CompanyRepresentativeID",
                table: "CompanyJobRepresentitives",
                column: "CompanyRepresentativeID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobs_CompanyID",
                table: "CompanyJobs",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobs_CoreKbJobID",
                table: "CompanyJobs",
                column: "CoreKbJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobSkills_CompanyJobID",
                table: "CompanyJobSkills",
                column: "CompanyJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyJobSkills_CoreKbSkillID",
                table: "CompanyJobSkills",
                column: "CoreKbSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRelatedIndustries_CompanyID",
                table: "CompanyRelatedIndustries",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRelatedIndustries_CoreKbIndustryID",
                table: "CompanyRelatedIndustries",
                column: "CoreKbIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRepresentatives_CompanyID",
                table: "CompanyRepresentatives",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRepresentatives_IntegratorUserID",
                table: "CompanyRepresentatives",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRepresentiveBranches_CompanyBranchID",
                table: "CompanyRepresentiveBranches",
                column: "CompanyBranchID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyRepresentiveBranches_CompanyRepresentativeID",
                table: "CompanyRepresentiveBranches",
                column: "CompanyRepresentativeID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_ContactDetailTypeID",
                table: "ContactDetails",
                column: "ContactDetailTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKbIndustries_CoreKbIndustryCategoryID",
                table: "CoreKbIndustries",
                column: "CoreKbIndustryCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKbIndustryJobs_CoreKbIndustryID",
                table: "CoreKbIndustryJobs",
                column: "CoreKbIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKbIndustryJobs_CoreKbJobID",
                table: "CoreKbIndustryJobs",
                column: "CoreKbJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKbJobSkills_CoreKbJobID",
                table: "CoreKbJobSkills",
                column: "CoreKbJobID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKbJobSkills_CoreKbSkillID",
                table: "CoreKbJobSkills",
                column: "CoreKbSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreKbSkills_CoreSkillCategoryID",
                table: "CoreKbSkills",
                column: "CoreSkillCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CoreSkillCategories_CoreKbSkillTypeID",
                table: "CoreSkillCategories",
                column: "CoreKbSkillTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CurriculumViteas_IntegratorUserID",
                table: "CurriculumViteas",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAddresses_AddressID",
                table: "IndividualAddresses",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualAddresses_IntegratorUserID",
                table: "IndividualAddresses",
                column: "IntegratorUserID");

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
                name: "IX_Suburbs_CityID",
                table: "Suburbs",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFiles_FileID",
                table: "UserFiles",
                column: "FileID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFiles_IntegratorUserID",
                table: "UserFiles",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobRelatedIndustries_CoreKbIndustryID",
                table: "UserJobRelatedIndustries",
                column: "CoreKbIndustryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobRelatedIndustries_UserJobID",
                table: "UserJobRelatedIndustries",
                column: "UserJobID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_CompanyID",
                table: "UserJobs",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_CoreKbJobID",
                table: "UserJobs",
                column: "CoreKbJobID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_CurriculumViteaID",
                table: "UserJobs",
                column: "CurriculumViteaID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_IntegratorUserID",
                table: "UserJobs",
                column: "IntegratorUserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobSkills_CoreKbSkillID",
                table: "UserJobSkills",
                column: "CoreKbSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobSkills_UserJobID",
                table: "UserJobSkills",
                column: "UserJobID");

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
                name: "AgentAreas");

            migrationBuilder.DropTable(
                name: "CompanyContactDetails");

            migrationBuilder.DropTable(
                name: "CompanyJobAssociatedBranches");

            migrationBuilder.DropTable(
                name: "CompanyJobListings");

            migrationBuilder.DropTable(
                name: "CompanyJobRelatedIndustries");

            migrationBuilder.DropTable(
                name: "CompanyJobRepresentitives");

            migrationBuilder.DropTable(
                name: "CompanyJobSkills");

            migrationBuilder.DropTable(
                name: "CompanyRepresentiveBranches");

            migrationBuilder.DropTable(
                name: "CoreKbIndustryJobs");

            migrationBuilder.DropTable(
                name: "CoreKbJobSkills");

            migrationBuilder.DropTable(
                name: "IndividualAddresses");

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
                name: "UserJobRelatedIndustries");

            migrationBuilder.DropTable(
                name: "UserJobSkills");

            migrationBuilder.DropTable(
                name: "UserPictures");

            migrationBuilder.DropTable(
                name: "UserQualifications");

            migrationBuilder.DropTable(
                name: "WorkExperienceReferenceContactDetails");

            migrationBuilder.DropTable(
                name: "CompanyRelatedIndustries");

            migrationBuilder.DropTable(
                name: "CompanyJobs");

            migrationBuilder.DropTable(
                name: "CompanyBranches");

            migrationBuilder.DropTable(
                name: "CompanyRepresentatives");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "IntegratorRoles");

            migrationBuilder.DropTable(
                name: "CoreKbSkills");

            migrationBuilder.DropTable(
                name: "UserJobs");

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
                name: "CoreKbIndustries");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CoreSkillCategories");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CoreKbJobs");

            migrationBuilder.DropTable(
                name: "CurriculumViteas");

            migrationBuilder.DropTable(
                name: "ContactDetailTypes");

            migrationBuilder.DropTable(
                name: "CoreKbIndustryCategories");

            migrationBuilder.DropTable(
                name: "Suburbs");

            migrationBuilder.DropTable(
                name: "CoreKbSkillTypes");

            migrationBuilder.DropTable(
                name: "IntegratorUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
