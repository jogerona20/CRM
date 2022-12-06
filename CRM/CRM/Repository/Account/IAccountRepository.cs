using CRM.Domain;
using CRM.Models.DTO;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public interface IAccountRepository
    {
        IEnumerable<Cliente> GetClientes();
        Task<Cliente> GetUserByEmailAsync(string email);

        Task<IdentityResult> CreateUserAsync(SignUpModel userModel);

        Task AddRoleToUser(string email, string role);

        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

        Task SignOutAsync();
        Task<Cliente> GetUserByIdsync(string id);
        Task CreateAdminRole();

        Task<bool> IsAdmin(string email);
    }
}
