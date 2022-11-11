using CRM.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Data.DBContext
{
    public class ProductoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public ProductoDbContext(DbContextOptions<ProductoDbContext> options)
        : base(options)
        {

        }

        public DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Producto>()
                .HasKey(b => b.SKU);
        }
    }
}
