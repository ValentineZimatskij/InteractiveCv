using Microsoft.EntityFrameworkCore;

namespace InteractiveCv.Server.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Experience> Experiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Experience>().HasData(
                new Experience
                {
                    Id = 1,
                    Company = "ЗАО Вольна",
                    Position = "техник-программист",
                    Period = "2024-2025",
                    Description = "Разрабатывал и внедрял системы диспетчеризации",
                    Order = 1
                },
                new Experience
                {
                    Id = 2,
                    Company = "Армия РБ",
                    Position = "Радист",
                    Period = "2025-2027",
                    Description = "Служил",
                    Order = 2
                }
            );
        }
    }
}
