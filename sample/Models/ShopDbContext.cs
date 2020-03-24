using System;
using Microsoft.EntityFrameworkCore;

namespace sample.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=shop.db");
    }
}
