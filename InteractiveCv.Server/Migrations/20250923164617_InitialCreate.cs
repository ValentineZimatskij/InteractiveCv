using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InteractiveCv.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Institution = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Degree = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Period = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Company = table.Column<string>(type: "text", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    Period = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Technologies = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Technologies = table.Column<string>(type: "text", nullable: true),
                    GitHubUrl = table.Column<string>(type: "text", nullable: true),
                    LiveUrl = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    IsFeatured = table.Column<bool>(type: "boolean", nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Level = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Order = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "CreatedAt", "Degree", "Description", "Institution", "Order", "Period" },
                values: new object[] { 1, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(6429), "Bachelor of Computer Science", "Изучение алгоритмов, структур данных, баз данных и веб-разработки", "Technical University", 1, "2016 - 2020" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "Company", "CreatedAt", "Description", "Order", "Period", "Position", "Technologies", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Example Tech Company", new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(3788), "Разработка веб-приложений с использованием ASP.NET Core и React. Архитектура микросервисов, контейнеризация с Docker.", 1, "2022 - Present", "Senior Full-Stack Developer", "ASP.NET Core, React, PostgreSQL, Docker, Azure", new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(3794) },
                    { 2, "Another Software House", new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(5579), "Разработка backend для enterprise приложений. Работа с Entity Framework, SQL Server.", 2, "2020 - 2022", "Middle .NET Developer", "C#, ASP.NET MVC, SQL Server, Entity Framework", new DateTime(2025, 9, 23, 16, 46, 15, 898, DateTimeKind.Utc).AddTicks(5579) }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedAt", "Description", "GitHubUrl", "ImageUrl", "IsFeatured", "LiveUrl", "Name", "Order", "Technologies", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(3959), "Персональное резюме в виде веб-приложения с интерактивной консолью", "https://github.com/yourusername/interactive-cv", null, true, null, "Interactive CV", 1, "ASP.NET Core, React, TypeScript, PostgreSQL, Docker", new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedAt", "Level", "Name", "Order" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(1824), "Expert", "C#", 1 },
                    { 2, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2946), "Advanced", "ASP.NET Core", 2 },
                    { 3, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2947), "Advanced", "React", 3 },
                    { 4, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2948), "Intermediate", "TypeScript", 4 },
                    { 5, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2949), "Intermediate", "PostgreSQL", 5 },
                    { 6, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2950), "Intermediate", "Docker", 6 },
                    { 7, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2951), "Advanced", "Git", 7 },
                    { 8, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2952), "Advanced", "HTML/CSS", 8 },
                    { 9, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2953), "Advanced", "JavaScript", 9 },
                    { 10, new DateTime(2025, 9, 23, 16, 46, 15, 899, DateTimeKind.Utc).AddTicks(2954), "Advanced", "Entity Framework", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Skills");
        }
    }
}
