using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameRoleAndWorkingPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserRoles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserWorkingPositions_WorkingPositionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserWorkingPositions");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkingPositions",
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
                    table.PrimaryKey("PK_WorkingPositions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6480), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6510), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6540), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6560), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6570), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6630), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6820), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6840), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6860), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6870), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6890), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6920), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6950), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6960), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Employee" }
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7110), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7170), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7180), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7220), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7230), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7250), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7260), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7280), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7290), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7310), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7320), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7340), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7350), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7370), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7380), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7400), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7410), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7430), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7440), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7470), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7490), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7510), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7520), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7540), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7550), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7570), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7580), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.InsertData(
                table: "WorkingPositions",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8120), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8120), "Software developer" },
                    { 2, new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8140), "Designer" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_WorkingPositions_WorkingPositionId",
                table: "Users",
                column: "WorkingPositionId",
                principalTable: "WorkingPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_WorkingPositions_WorkingPositionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "WorkingPositions");

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
                name: "UserWorkingPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DateCreated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWorkingPositions", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Employee" }
                });

            migrationBuilder.InsertData(
                table: "UserWorkingPositions",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(8990), "Software developer" },
                    { 2, new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(9000), new DateTime(2023, 4, 21, 10, 52, 22, 291, DateTimeKind.Utc).AddTicks(9000), "Designer" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserRoles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserWorkingPositions_WorkingPositionId",
                table: "Users",
                column: "WorkingPositionId",
                principalTable: "UserWorkingPositions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
