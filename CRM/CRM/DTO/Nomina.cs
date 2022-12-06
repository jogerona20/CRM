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
        public int Quincena { get; set; }
        public int DiasTrabajados { get; set; }
        public double Bono { get; set; }
        public double TotalDeducciones { get; set; }

        public int DiasDeIncapacidad { get; set; }
        public double ApoyoPatron { get; set; }


        public Nomina()
        {
            this.DiasTrabajados = DateTime.Today.Day;
            this.Quincena = this.DiasTrabajados <= 15 ? 1 : 2;
            if (this.Quincena == 2)
            {
                this.DiasTrabajados = this.DiasTrabajados - 15;
            }
        }

        public void CalcularNomina()
        {
            if (DiasDeIncapacidad > 3)
            {
                ApoyoPatron = 3 * empleado.SueldoBase; 
            }
            else
            {
                ApoyoPatron = DiasDeIncapacidad * empleado.SueldoBase;
            }
            if (DiasTrabajados - DiasDeIncapacidad <= 0)
            {
                this.DiasTrabajados = 0;
            }
            else
            {
                this.DiasTrabajados = DiasTrabajados - DiasDeIncapacidad;
            }
            this.SueldoAPagar = empleado.SueldoBase * this.DiasTrabajados + Bono + ApoyoPatron ;
            this.IMSS = (empleado.SueldoBase * DiasTrabajados) * .05;
            this.ISR = (empleado.SueldoBase * DiasTrabajados) * .17;
            if (this.empleado.CreditoInfonavit)
            {
                this.TotalDeducciones = IMSS + ISR + this.empleado.DescuentoInfonavit;
                this.Total = SueldoAPagar - TotalDeducciones;
            }
            else
            {
                this.TotalDeducciones = IMSS + ISR + this.empleado.DescuentoInfonavit;
                this.Total = SueldoAPagar - TotalDeducciones;
            }
        }
    }
}
