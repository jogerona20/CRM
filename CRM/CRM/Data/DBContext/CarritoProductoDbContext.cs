using CRM.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Data.DBContext
{
    public class CarritoProductoDbContext : IdentityDbContext<Cliente>
    {
        public CarritoProductoDbContext(DbContextOptions<CarritoProductoDbContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CarritoProducto>()
           .HasOne(p => p.Producto)
           .WithMany(b => b.CarritoProductos)
           .HasForeignKey(p => p.IdProducto);

            builder.Entity<CarritoProducto>()
            .HasOne(p => p.Venta)
            .WithMany(b => b.CarritoProductos)
            .HasForeignKey(p => p.IdVenta);

            builder.Entity<CarritoProducto>()
            .HasOne(p => p.Cliente)
            .WithMany(b => b.CarritoProductos)
            .HasForeignKey(p => p.ClienteID);

            builder.Entity<CarritoProducto>()
                .HasKey(b => b.Id);
        }
    }
}
