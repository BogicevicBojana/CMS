using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFreeDaysProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FreeDaysLastYear",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "FreeDaysThisYear",
                table: "Users",
                newName: "FreeDays");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9080), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9110), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9120), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9160), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9180), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9220), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9410), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9430), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9490), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9500), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9530), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9700), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9720), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9730), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9750), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9780), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9800), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9810), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9830), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9840), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9860), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9870), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9890), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9900), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9920), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9930), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9950), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9960), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9980), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9990), new DateTime(2023, 5, 22, 9, 14, 4, 483, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(10), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(20), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(40), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(50), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(60), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(80), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(100), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(110), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(130), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(630), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(630) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(650), new DateTime(2023, 5, 22, 9, 14, 4, 484, DateTimeKind.Utc).AddTicks(650) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FreeDays",
                table: "Users",
                newName: "FreeDaysThisYear");

            migrationBuilder.AddColumn<int>(
                name: "FreeDaysLastYear",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
    }
}
