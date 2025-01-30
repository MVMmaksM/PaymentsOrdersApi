using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        //for migration
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=orders;Username=postgres;Password=123456");
        }*/

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ManufacturerEntity> Manufacturers { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<SellerEntity> Sellers { get; set; }
        public DbSet<OrdersEntity> Orders { get; set; }
    }
}
