using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProjectAndNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "ProjectDeveloperSkills");

            migrationBuilder.DropTable(
                name: "ProjectDevelopers");

            migrationBuilder.DropTable(
                name: "ProjectSkills");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7330), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7350), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7370), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7380), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7400), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7420), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7430), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7450), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7460), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7480), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7660), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7680), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7690), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7710), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7720), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7740), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7750), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7770), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7780), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7800), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8020), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8070), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8080), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8120), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8130), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8150), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8160), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8180), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8190), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8220), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8240), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8260), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8270), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8290), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8300), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8330), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8350), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8360), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8380), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8390), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8420), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8430), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(9000), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(9000) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssignedToId = table.Column<int>(type: "integer", nullable: false),
                    CreatedById = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
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
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsCompanys = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDevelopers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7890), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7910), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7940), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7950), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8040), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8180), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8200), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8230), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8260), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8290), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8310), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8340), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8490), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8540), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8560), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8580), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8590), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8640), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8650), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8680), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8700), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8710), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8730), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8740), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8790), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8800), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8810), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8830), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8840), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8860), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8870), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8900), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8920), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8950), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9480) });

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
        }
    }
}
