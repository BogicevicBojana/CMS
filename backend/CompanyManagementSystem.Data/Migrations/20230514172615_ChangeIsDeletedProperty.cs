using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIsDeletedProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "WorkingPositions",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "Benefits",
                newName: "IsDeleted");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9890), new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9910), new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9930), new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9940), new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9970), new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 5, 14, 17, 26, 15, 484, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(30), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(190), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(210), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(230), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(240), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(260), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(270), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(290), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(300), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(310), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(330), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(480), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(490), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(510), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(520), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(540), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(560), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(570), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(590), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(600), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(620), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(630), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(650), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(660), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(680), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(680) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(690), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(710), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(760), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(760) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(780), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(780) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(790), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(810), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(820), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(840), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(850), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(870), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(880), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(900), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(910), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(910) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(930), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(940), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(960), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(1490), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(1500), new DateTime(2023, 5, 14, 17, 26, 15, 485, DateTimeKind.Utc).AddTicks(1500) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "WorkingPositions",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Benefits",
                newName: "isDeleted");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4470), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4490), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4510), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4530), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4550), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4560), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4610), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4630) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4820), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4860), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4880), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4890), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4890) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4910), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4930), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4940), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4960), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4970), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4990), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5150), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5170), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5180), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5200), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5210), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5230), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5250), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5260), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5280), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5290), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5310), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5320), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5340), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5350), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5370), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5380), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5400), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5410), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5480), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5490), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5510), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5530), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5540), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5560), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5570), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5590), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5600), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5620), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5630), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5650), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6270), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6290), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6290) });
        }
    }
}
