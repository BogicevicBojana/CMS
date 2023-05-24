using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVacationRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VacationRequests");

            migrationBuilder.DropTable(
                name: "RequestStatuses");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Vacations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8890), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8920), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8940), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8980), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9010), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9030), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9040), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9060), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9180), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9230), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9300), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9320), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9620), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9650), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9660), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9680), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9730), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9760), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9790), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9820), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9860), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9880), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9890), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9910), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9920), new DateTime(2023, 5, 24, 12, 13, 56, 441, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 442, DateTimeKind.Utc).AddTicks(350), new DateTime(2023, 5, 24, 12, 13, 56, 442, DateTimeKind.Utc).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 24, 12, 13, 56, 442, DateTimeKind.Utc).AddTicks(360), new DateTime(2023, 5, 24, 12, 13, 56, 442, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_UserId",
                table: "Vacations",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Users_UserId",
                table: "Vacations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Users_UserId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_UserId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Vacations");

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
                name: "VacationRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProcessedById = table.Column<int>(type: "integer", nullable: false),
                    RequestedById = table.Column<int>(type: "integer", nullable: false),
                    RequestStatusId = table.Column<int>(type: "integer", nullable: false),
                    VacationId = table.Column<int>(type: "integer", nullable: false),
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

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7860), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7880), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7900), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7910), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7930), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7950), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7960), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7990), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8150), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8160), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8180), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8190), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8220), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8240), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8250), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8260), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.InsertData(
                table: "RequestStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Rejected" },
                    { 3, "Accepted" }
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8420), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8480), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8490), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8520), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8540), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8550), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8570), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8580), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8600), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8630), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8640), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8660), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8690), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8700), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8720), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8730), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8750), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8780), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8790), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8810), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8820), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8840), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8850), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8870), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8900), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(9400), new DateTime(2023, 5, 22, 13, 21, 2, 953, DateTimeKind.Utc).AddTicks(9400) });

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
    }
}
