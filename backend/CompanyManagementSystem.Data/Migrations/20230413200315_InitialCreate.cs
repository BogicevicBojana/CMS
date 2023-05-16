using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    IsCompanys = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReligiousHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReligiousHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserWorkingPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWorkingPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    WorkingPositionId = table.Column<int>(type: "integer", nullable: false),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: false),
                    MobileNumber = table.Column<string>(type: "text", nullable: false),
                    FreeDaysThisYear = table.Column<int>(type: "integer", nullable: false),
                    FreeDaysLastYear = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "UserStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_UserWorkingPositions_WorkingPositionId",
                        column: x => x.WorkingPositionId,
                        principalTable: "UserWorkingPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    AssignedToId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notes_Users_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notes_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDevelopers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDevelopers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDevelopers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectDevelopers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BenefitId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBenefits_Benefits_BenefitId",
                        column: x => x.BenefitId,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBenefits_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LanguageId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLanguages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLanguages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReligiousHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ReligiousHolidayId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReligiousHolidays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReligiousHolidays_ReligiousHolidays_ReligiousHolidayId",
                        column: x => x.ReligiousHolidayId,
                        principalTable: "ReligiousHolidays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReligiousHolidays_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false),
                    SkillRatingId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSkills_SkillRatings_SkillRatingId",
                        column: x => x.SkillRatingId,
                        principalTable: "SkillRatings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_Skills_SkillRatingId",
                        column: x => x.SkillRatingId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserSkills_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VacationRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequestedById = table.Column<int>(type: "integer", nullable: false),
                    VacationId = table.Column<int>(type: "integer", nullable: false),
                    RequestStatusId = table.Column<int>(type: "integer", nullable: false),
                    ProcessedById = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VacationRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VacationRequests_RequestStatuses_RequestStatusId",
                        column: x => x.RequestStatusId,
                        principalTable: "RequestStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacationRequests_Users_ProcessedById",
                        column: x => x.ProcessedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacationRequests_Users_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VacationRequests_Vacations_VacationId",
                        column: x => x.VacationId,
                        principalTable: "Vacations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDeveloperSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectDeveloperId = table.Column<int>(type: "integer", nullable: false),
                    ProjectSkillId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDeveloperSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectDeveloperSkills_ProjectDevelopers_ProjectDeveloperId",
                        column: x => x.ProjectDeveloperId,
                        principalTable: "ProjectDevelopers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectDeveloperSkills_ProjectSkills_ProjectSkillId",
                        column: x => x.ProjectSkillId,
                        principalTable: "ProjectSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Benefits",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8540), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8540), "Private health insurance" },
                    { 2, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8560), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8560), "Foreign language lessons" },
                    { 3, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8580), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8580), "Remote work" },
                    { 4, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8590), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8590), "Employee learning and advancement" },
                    { 5, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8610), "Paid courses and literature for professional development" },
                    { 6, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8630), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8630), "Additional day off for one year of experience (+1 day)" },
                    { 7, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8640), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8640), "Additional days off for more than three years of experience (+2 days)" },
                    { 8, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8660), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8660), "Paid sports activities" },
                    { 9, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8670), "Parents day off (+1 day)" },
                    { 10, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8690), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8690), "Courses for team-leader positions" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8880), false, "English" },
                    { 2, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8890), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8890), false, "German" },
                    { 3, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8910), false, "Russian" },
                    { 4, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8930), false, "French" },
                    { 5, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8940), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8940), false, "Turkish" },
                    { 6, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8960), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8960), false, "Italian" },
                    { 7, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8970), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8970), false, "Spanish" },
                    { 8, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8990), false, "Polish" },
                    { 9, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9000), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9000), false, "Dutch" },
                    { 10, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9020), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9020), false, "Serbian" }
                });

            migrationBuilder.InsertData(
                table: "RequestStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending acceptance" },
                    { 2, "Pending" },
                    { 3, "Rejected" },
                    { 4, "Accepted" }
                });

            migrationBuilder.InsertData(
                table: "SkillRatings",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Doesn't have knowledge.", "R0" },
                    { 2, "Can't work on a commercial project, doesn't have enough knowledge.", "R1" },
                    { 3, "Can work on a commercial project but it needs help (mentoring, monitoring).It will need more time for each task and someone experienced must be available during the project.", "R2" },
                    { 4, "Can work on a commercial project independently, but it cannot adapt the work to different contexts or unusual situations, and for complicated cases it will need help.", "R3" },
                    { 5, "Works completely independently on a commercial project, adapts work to different contexts, introduces innovations, solves complicated cases.", "R4" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "DateCreated", "DateModified", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9180), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9180), false, "JavaScript" },
                    { 2, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9190), false, "AngularJS" },
                    { 3, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9210), false, "TypeScript" },
                    { 4, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9230), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9230), false, "Angular" },
                    { 5, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9240), false, "ReactJS" },
                    { 6, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9260), false, "CSS" },
                    { 7, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9270), false, "Ruby (Ruby on Rails)" },
                    { 8, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9290), false, "Python" },
                    { 9, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9340), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9340), false, "Java" },
                    { 10, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9360), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9360), false, "SQL" },
                    { 11, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9380), false, "PostgreSQL" },
                    { 12, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9390), false, "MongoDB" },
                    { 13, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9410), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9410), false, "GitHub" },
                    { 14, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9420), false, "Jira" },
                    { 15, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9440), false, "Kotlin" },
                    { 16, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9450), false, "Object C" },
                    { 17, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9470), false, "Swift" },
                    { 18, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9510), false, "Xmpp" },
                    { 19, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9520), false, "Flutter" },
                    { 20, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9540), false, "C#" },
                    { 21, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9550), false, "C" },
                    { 22, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9570), false, "C++" },
                    { 23, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9580), false, "Haskell" },
                    { 24, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9600), false, "Hardware Design / Embedded" },
                    { 25, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9610), false, "PHP" },
                    { 26, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9630), false, "Dart" },
                    { 27, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9640), false, "Selenium" },
                    { 28, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9660), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9660), false, "Appium" },
                    { 29, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9670), false, "TestNG" },
                    { 30, new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9690), false, "xUnit" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "UserStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Active" },
                    { 3, "Inactive" }
                });

            migrationBuilder.InsertData(
                table: "UserWorkingPositions",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(420), new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(420), "Software developer" },
                    { 2, new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(430), new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(430), "Designer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_AssignedToId",
                table: "Notes",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CreatedById",
                table: "Notes",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDevelopers_ProjectId",
                table: "ProjectDevelopers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDevelopers_UserId",
                table: "ProjectDevelopers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDeveloperSkills_ProjectDeveloperId",
                table: "ProjectDeveloperSkills",
                column: "ProjectDeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectDeveloperSkills_ProjectSkillId",
                table: "ProjectDeveloperSkills",
                column: "ProjectSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_ProjectId",
                table: "ProjectSkills",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_SkillId",
                table: "ProjectSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBenefits_BenefitId",
                table: "UserBenefits",
                column: "BenefitId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBenefits_UserId",
                table: "UserBenefits",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_LanguageId",
                table: "UserLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLanguages_UserId",
                table: "UserLanguages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReligiousHolidays_ReligiousHolidayId",
                table: "UserReligiousHolidays",
                column: "ReligiousHolidayId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReligiousHolidays_UserId",
                table: "UserReligiousHolidays",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_StatusId",
                table: "Users",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_WorkingPositionId",
                table: "Users",
                column: "WorkingPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillRatingId",
                table: "UserSkills",
                column: "SkillRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_UserId",
                table: "UserSkills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequests_ProcessedById",
                table: "VacationRequests",
                column: "ProcessedById");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequests_RequestedById",
                table: "VacationRequests",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequests_RequestStatusId",
                table: "VacationRequests",
                column: "RequestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_VacationRequests_VacationId",
                table: "VacationRequests",
                column: "VacationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "ProjectDeveloperSkills");

            migrationBuilder.DropTable(
                name: "PublicHolidays");

            migrationBuilder.DropTable(
                name: "UserBenefits");

            migrationBuilder.DropTable(
                name: "UserLanguages");

            migrationBuilder.DropTable(
                name: "UserReligiousHolidays");

            migrationBuilder.DropTable(
                name: "UserSkills");

            migrationBuilder.DropTable(
                name: "VacationRequests");

            migrationBuilder.DropTable(
                name: "ProjectDevelopers");

            migrationBuilder.DropTable(
                name: "ProjectSkills");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "ReligiousHolidays");

            migrationBuilder.DropTable(
                name: "SkillRatings");

            migrationBuilder.DropTable(
                name: "RequestStatuses");

            migrationBuilder.DropTable(
                name: "Vacations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserStatuses");

            migrationBuilder.DropTable(
                name: "UserWorkingPositions");
        }
    }
}
