using Microsoft.EntityFrameworkCore;

namespace InteractiveCv.Server.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Education> Educations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Используем фиксированные даты вместо DateTime.UtcNow
            var fixedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            // Навыки со строковыми уровнями
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "C#", Level = "Expert", Order = 1, CreatedAt = fixedDate },
                new Skill { Id = 2, Name = "ASP.NET Core", Level = "Advanced", Order = 2, CreatedAt = fixedDate },
                new Skill { Id = 3, Name = "React", Level = "Advanced", Order = 3, CreatedAt = fixedDate },
                new Skill { Id = 4, Name = "TypeScript", Level = "Intermediate", Order = 4, CreatedAt = fixedDate },
                new Skill { Id = 5, Name = "PostgreSQL", Level = "Intermediate", Order = 5, CreatedAt = fixedDate },
                new Skill { Id = 6, Name = "Docker", Level = "Intermediate", Order = 6, CreatedAt = fixedDate },
                new Skill { Id = 7, Name = "Git", Level = "Advanced", Order = 7, CreatedAt = fixedDate }
            );

            // Начальные данные для опыта работы
            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1,
                    Company = "Example Tech Company",
                    Position = "Senior Full-Stack Developer",
                    Period = "2022 - Present",
                    Description = "Разработка веб-приложений с использованием ASP.NET Core и React. Архитектура микросервисов, контейнеризация с Docker.",
                    Technologies = "ASP.NET Core, React, PostgreSQL, Docker, Azure",
                    Order = 1,
                    CreatedAt = fixedDate,
                    UpdatedAt = fixedDate
                },
                new Experience
                {
                    Id = 2,
                    Company = "Another Software House",
                    Position = "Middle .NET Developer",
                    Period = "2020 - 2022",
                    Description = "Разработка backend для enterprise приложений. Работа с Entity Framework, SQL Server.",
                    Technologies = "C#, ASP.NET MVC, SQL Server, Entity Framework",
                    Order = 2,
                    CreatedAt = fixedDate,
                    UpdatedAt = fixedDate
                }
            );

            // Начальные данные для проектов
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Name = "Interactive CV",
                    Description = "Персональное резюме в виде веб-приложения с интерактивной консолью",
                    Technologies = "ASP.NET Core, React, TypeScript, PostgreSQL, Docker",
                    IsFeatured = true,
                    Order = 1,
                    CreatedAt = fixedDate,
                    UpdatedAt = fixedDate
                }
            );

            // Начальные данные для образования
            modelBuilder.Entity<Education>().HasData(
                new Education
                {
                    Id = 1,
                    Institution = "Technical University",
                    Degree = "Bachelor of Computer Science",
                    Period = "2016 - 2020",
                    Description = "Изучение алгоритмов, структур данных, баз данных и веб-разработки",
                    Order = 1,
                    CreatedAt = fixedDate
                }
            );
        }
    }
}
