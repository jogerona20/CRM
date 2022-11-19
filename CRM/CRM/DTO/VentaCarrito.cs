using CRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DTO
{
    public class VentaCarrito
    {
        public Venta Venta { get; set; }

        public List<CarritoProducto> CarritoProductos { get; set; }
    }
}
