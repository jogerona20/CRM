using CRM.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CRM.Helper.Claims
{
    public class ClientClaimsPrincipalFactory :  UserClaimsPrincipalFactory<Cliente, IdentityRole>
    {
        public ClientClaimsPrincipalFactory(UserManager<Cliente> userManager,
         RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> options)
         : base(userManager, roleManager, options)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(Cliente cliente)
        {
            var identity = await base.GenerateClaimsAsync(cliente);
            identity.AddClaim(new Claim("UserFullName", cliente.NombreCompleto ?? ""));
            identity.AddClaim(new Claim("UserEmail", cliente.Email ?? ""));

            return identity;
        }
    }
}
