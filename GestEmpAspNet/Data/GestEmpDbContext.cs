using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class GestEmpDbContext: DbContext
    {
        public DbSet<Departement> Departements { get; set; }=null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
            "Server=localhost;Port=3306;Database=GestEmpDb;User=root;Password=;",
                new MySqlServerVersion(new Version(5, 7, 39)) // Spécifiez votre version MySQL
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departement>().ToTable("Departements");
            modelBuilder.Entity<Departement>().HasKey(d => d.Id);
            modelBuilder.Entity<Departement>()
            .Property(d => d.Name)
            .IsRequired().
            HasMaxLength(50);
            // Configuration supplémentaire si nécessaire
        }
    }
}