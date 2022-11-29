using CRM.Core;
using CRM.Data.DBContext;
using CRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(EmpleadoDbContext context) : base(context)
        {
        }
    }
}
