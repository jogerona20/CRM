using CRM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.DTO
{
    public class Nomina
    {
        public Empleado empleado { get; set; }
        public double SueldoAPagar {get; set;}
        public double IMSS { get; set; }
        public double ISR { get; set; }
        public double Total { get; set; }



        public void CalcularNomina()
        {
            var dias = DateTime.Today.Day;
            this.SueldoAPagar = empleado.SueldoBase * dias;
            this.IMSS = SueldoAPagar * .05;
            this.ISR = SueldoAPagar * .17;
            this.Total = SueldoAPagar - IMSS - ISR;
        }
    }
}
