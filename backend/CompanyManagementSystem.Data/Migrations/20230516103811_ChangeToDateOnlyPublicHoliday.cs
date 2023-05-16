using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToDateOnlyPublicHoliday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "PublicHolidays",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EndDate",
                table: "PublicHolidays",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6200), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6220), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6240), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6260), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6290), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6310), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6320), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6340), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6350), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6370), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6540), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6560), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6570), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6600), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6670), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6810), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6820), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6840), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6850), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6870), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6880), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6900), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6930), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6940), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6960), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6980), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6990), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7010), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7020), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7030), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7050), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7060), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7080), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7090), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7110), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7140), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7150), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7170), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7180), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7200), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7210), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7220), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7240), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7260), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7790), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7810), new DateTime(2023, 5, 16, 10, 38, 11, 78, DateTimeKind.Utc).AddTicks(7810) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "PublicHolidays",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "PublicHolidays",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

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
    }
}
