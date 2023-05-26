using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToDateOnlyToReligiousHoliday : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5530), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5550), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5570), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5590), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5600), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5620), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5720), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5740), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5760), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5930), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5940), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5960), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5970), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5990), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6000), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6020), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6030), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6050), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6070), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6250), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6260), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6280), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6300), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6310), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6330), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6340), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6360), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6380), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6410), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6430), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6440), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6460), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6470), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6480), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6500), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6520), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6530), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6550), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6560), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6580), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6590), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6610), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6620), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6640), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6650), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6670), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6680), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6700), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6710), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(7320), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(7340), new DateTime(2023, 5, 16, 10, 7, 9, 592, DateTimeKind.Utc).AddTicks(7340) });
        }
    }
}
