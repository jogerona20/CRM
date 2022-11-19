using CRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Producto : DomainBase
    {
        [Required]
        public string SKU { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public string Descripcion { get; set; }

        public List<CarritoProducto> CarritoProductos { get; set; }

    }
}
