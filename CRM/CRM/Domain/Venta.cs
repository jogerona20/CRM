using CRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Venta : DomainBase
    {
        [Required]
        public string ClienteId { get; set; }
        public DateTime Fecha { get; set; }
        public List<CarritoProducto> CarritoProductos { get; set; }
        public Cliente Cliente { get; set; }
        public string EstatusEnvio { get; set; }
        public double Importe { get; set; }

    }
}
