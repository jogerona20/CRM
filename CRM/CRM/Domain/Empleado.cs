using CRM.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Empleado : DomainBase
    {
        [Required]
        public String NombreCompleto { get; set; }
        [Required]
        public double SueldoBase { get; set; }
        [Required]
        public String RFC { get; set; }
        [Required]
        public String Direccion { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }
    }
}
