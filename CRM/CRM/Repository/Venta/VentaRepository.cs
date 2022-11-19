using CRM.Core;
using CRM.Data.DBContext;
using CRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class VentaRepository : Repository<Venta>, IVentaRepository
    {
        public VentaRepository(ProductoDbContext context) : base(context)
        {
        }
    }
}
