using CRM.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Data.DBContext
{
    public class EmpleadoDbContext : DbContext 
    {
        public EmpleadoDbContext(DbContextOptions<EmpleadoDbContext> options)
        : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Empleado>()
                .HasKey(b => b.Id);
        }
    }
}
