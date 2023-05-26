using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReseedEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserStatuses",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.UpdateData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Accepted");

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
                table: "UserStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "UserStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Inactive");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pending acceptance");

            migrationBuilder.UpdateData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "RequestStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Rejected");

            migrationBuilder.InsertData(
                table: "RequestStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Accepted" });

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
                table: "UserStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "UserStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Active");

            migrationBuilder.InsertData(
                table: "UserStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Inactive" });

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
    }
}
