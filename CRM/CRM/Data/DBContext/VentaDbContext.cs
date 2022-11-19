using CRM.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Data.DBContext
{
    public class VentaDbContext : IdentityDbContext<Cliente>
    {

        public VentaDbContext(DbContextOptions<VentaDbContext> options)
        : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Venta>()
           .HasOne(p => p.Cliente)
           .WithMany(b => b.Ventas)
           .HasForeignKey(p => p.ClienteId);

            builder.Entity<Venta>()
                .HasKey(b => b.Id);
        }
    }
}
