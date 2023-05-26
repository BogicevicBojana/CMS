using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class MakePropertiesNullableForUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4120), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4140), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4150), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4170), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4190), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4200), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4220), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4230), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4250), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4260), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4470), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4480), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4500), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4510), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4530), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4540), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4540) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4560), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4560) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4570), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4590), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4600), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4750), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4770), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4790), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4810), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4820), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4840), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4860), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4870), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4880), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4900), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4910), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4930), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4940), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4960), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4970), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4970) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4990), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5000), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5020), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5080), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5090), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5110), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5120), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5130), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5150), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5160), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5180), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5190), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5210), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5220), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5230), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5770), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "WorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5790), new DateTime(2023, 5, 22, 13, 19, 9, 848, DateTimeKind.Utc).AddTicks(5790) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MobileNumber",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
    }
}
