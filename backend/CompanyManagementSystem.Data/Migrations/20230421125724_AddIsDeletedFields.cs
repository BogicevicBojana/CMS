using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddIsDeletedFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "WorkingPositions",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Benefits",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4470), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4470), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4490), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4490), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4510), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4510), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4530), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4530), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4550), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4550), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4560), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4560), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4580), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4580), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4600), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4610), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4610), false });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4630), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(4630), false });

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
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6270), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6270), false });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "isDeleted" },
                values: new object[] { new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6290), new DateTime(2023, 4, 21, 12, 57, 24, 562, DateTimeKind.Utc).AddTicks(6290), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "WorkingPositions");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Benefits");

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

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8120), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8140), new DateTime(2023, 4, 21, 11, 28, 42, 432, DateTimeKind.Utc).AddTicks(8140) });
        }
    }
}
