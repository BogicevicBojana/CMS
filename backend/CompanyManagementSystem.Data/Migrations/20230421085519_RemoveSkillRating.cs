using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CompanyManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSkillRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_SkillRatings_SkillRatingId",
                table: "UserSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillRatingId",
                table: "UserSkills");

            migrationBuilder.DropTable(
                name: "SkillRatings");

            migrationBuilder.DropIndex(
                name: "IX_UserSkills_SkillRatingId",
                table: "UserSkills");

            migrationBuilder.DropColumn(
                name: "SkillRatingId",
                table: "UserSkills");

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7890), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7910), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7940), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7950), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7970), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8010), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8030), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8040), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8180), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8200), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8210), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8230), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8260), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8290), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8310), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8320), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8340), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8490), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8510), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8530), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8540), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8560), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8580), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8590), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8640), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8650), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8680), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8700), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8710), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8730), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8740), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8760), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8770), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8790), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8800), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8810), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8830), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8840), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8860), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8870), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8900), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8920), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8950), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9460), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9480), new DateTime(2023, 4, 21, 8, 55, 19, 830, DateTimeKind.Utc).AddTicks(9480) });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserSkills_Skills_SkillId",
                table: "UserSkills");

            migrationBuilder.DropIndex(
                name: "IX_UserSkills_SkillId",
                table: "UserSkills");

            migrationBuilder.AddColumn<int>(
                name: "SkillRatingId",
                table: "UserSkills",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SkillRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillRatings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8540), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8560), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8580), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8590), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8610), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8630), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8640), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8660), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8670), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Benefits",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8690), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8880), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8890), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8910), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8930), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8940), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8960), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8970), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8990), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9000), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9020), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9020) });

            migrationBuilder.InsertData(
                table: "SkillRatings",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Doesn't have knowledge.", "R0" },
                    { 2, "Can't work on a commercial project, doesn't have enough knowledge.", "R1" },
                    { 3, "Can work on a commercial project but it needs help (mentoring, monitoring).It will need more time for each task and someone experienced must be available during the project.", "R2" },
                    { 4, "Can work on a commercial project independently, but it cannot adapt the work to different contexts or unusual situations, and for complicated cases it will need help.", "R3" },
                    { 5, "Works completely independently on a commercial project, adapts work to different contexts, introduces innovations, solves complicated cases.", "R4" }
                });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9180), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9190), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9210), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9210) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9230), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9240), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9260), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9270), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9290), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9340), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9360), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9380), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9390), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9410), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9420), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9440), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9450), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9450) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9470), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9510), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9520), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9540), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9550), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9550) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9570), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9580), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9600), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9610), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9630), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9640), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9660), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9670), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9690), new DateTime(2023, 4, 13, 20, 3, 14, 925, DateTimeKind.Utc).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(420), new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "UserWorkingPositions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(430), new DateTime(2023, 4, 13, 20, 3, 14, 926, DateTimeKind.Utc).AddTicks(430) });

            migrationBuilder.CreateIndex(
                name: "IX_UserSkills_SkillRatingId",
                table: "UserSkills",
                column: "SkillRatingId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_SkillRatings_SkillRatingId",
                table: "UserSkills",
                column: "SkillRatingId",
                principalTable: "SkillRatings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSkills_Skills_SkillRatingId",
                table: "UserSkills",
                column: "SkillRatingId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
