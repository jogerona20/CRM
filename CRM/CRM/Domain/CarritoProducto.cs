using CRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class CarritoProducto : DomainBase
    {
        [Required]
        public int IdProducto { get; set; }
        public int? IdVenta { get; set; }
        public string? ClienteID { get; set; }
        [Required]
        public double Precio { get; set; }
        public Producto Producto { get; set; }
        public Venta Venta { get; set; }
        public Cliente Cliente { get; set; }
    }
}
