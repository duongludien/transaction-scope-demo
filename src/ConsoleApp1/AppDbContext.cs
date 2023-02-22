using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    public class AppDbContext : DbContext
    {
        public DbSet<Sample> Samples { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Test;User Id=sa;Password=YOURPASSWORD;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();
            });
        }
    }
}
