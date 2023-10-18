
using Microsoft.EntityFrameworkCore;
using StockApp.Blazor.Data;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;


namespace StokApp.Blazor.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Record> Records { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Stock>().HasData(
                new Stock()
                {
                    Id = 1,
                    StockCode = "435465756",
                    StockName = "Buzdolabı"
                },
                new Stock()
                {
                    Id = 2,
                    StockCode = "435465775",
                    StockName = "Televizyon"
                },
                new Stock()
                {
                    Id = 3,
                    StockCode = "435465783",
                    StockName = "Çamaşır Makinesi"
                },
                new Stock()
                {
                    Id = 4,
                    StockCode = "435465796",
                    StockName = "Kahve Makinesi"
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}