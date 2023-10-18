using Microsoft.EntityFrameworkCore;
using StockApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Record> Records { get; set; }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.Entity)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                break;
                            }
                    }
                }
            }
            return base.SaveChanges();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedDate = DateTime.Now;
                                break;
                            }
                    }
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

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
