using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveCv.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GitHubUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(3788), new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(3794) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(5579), new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(5579) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GitHubUrl", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(3959), "https://github.com/yourusername/interactive-cv", new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "Level", "Name", "Order" },
                values: new object[,]
                {
                    { 8, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2952), "Advanced", "HTML/CSS", 8 },
                    { 9, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2953), "Advanced", "JavaScript", 9 },
                    { 10, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2954), "Advanced", "Entity Framework", 10 }
                });
        }
    }
}
