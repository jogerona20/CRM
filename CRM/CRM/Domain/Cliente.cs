using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Domain
{
    public class Cliente : IdentityUser
    {
        [Required, EmailAddress]
        public string Correo { get; set; }
        [Required]
        public string NombreCompleto { get; set; }
        [Required]
        public string Direccion { get; set; }
        public List<Venta> Ventas { get; set; }

    }
}
