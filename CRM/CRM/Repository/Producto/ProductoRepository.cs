using CRM.Core;
using CRM.Data.DBContext;
using CRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        public ProductoRepository(ProductoDbContext context) : base(context)
        {
        }
    }
}
