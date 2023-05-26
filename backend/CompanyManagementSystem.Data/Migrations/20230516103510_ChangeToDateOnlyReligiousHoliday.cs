using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToDateOnlyReligiousHoliday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "ReligiousHolidays",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8900), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8950), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8960), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8980), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9010), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9020), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9160), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9170), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9200), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9220), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9230), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9310), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9320), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9340), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9560), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9650), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9680), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9700), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9710), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9730), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9740), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9770), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9800), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9820), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9850), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9870), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9880), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9910), new DateTime(2023, 5, 16, 10, 35, 10, 557, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 558, DateTimeKind.Utc).AddTicks(430), new DateTime(2023, 5, 16, 10, 35, 10, 558, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 35, 10, 558, DateTimeKind.Utc).AddTicks(440), new DateTime(2023, 5, 16, 10, 35, 10, 558, DateTimeKind.Utc).AddTicks(440) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "ReligiousHolidays",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2280), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2300), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2320), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2330), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2350), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2370), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2380), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2400), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2410), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2440), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2610), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2630), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2640), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2660), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2670), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2690), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2700), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2720), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2730), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2750), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2950), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2960), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2980), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(2990), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3010), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3030), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3040), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3060), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3070), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3090), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3100), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3120), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3130), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3150), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3160), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3180), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3190), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3210), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3220), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3240), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3250), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3260), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3280), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3290), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3310), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3320), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3340), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3350), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3360), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3380), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3900), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3910), new DateTime(2023, 5, 16, 10, 25, 56, 413, DateTimeKind.Utc).AddTicks(3910) });
        }
    }
}
