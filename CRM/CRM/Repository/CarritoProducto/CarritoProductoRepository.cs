using CRM.Core;
using CRM.Data.DBContext;
using CRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class CarritoProductoRepository:  Repository<CarritoProducto>, ICarritoProductoRepository
    {
        public CarritoProductoRepository(CarritoProductoDbContext context) : base(context)
        {
        }
    }
}
