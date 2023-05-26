using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeToDateOnly : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "StartDate",
                table: "Vacations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EndDate",
                table: "Vacations",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EmploymentDate",
                table: "Users",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "DateOfBirth",
                table: "Users",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Vacations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Vacations",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EmploymentDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "Users",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

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
    }
}
