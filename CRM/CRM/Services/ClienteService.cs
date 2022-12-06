using CRM.Domain;
using CRM.Models.DTO;
using CRM.Repository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IAccountRepository accountRepository;


        public ClienteService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public async Task<Cliente> GetUserByEmailAsync(string email)
        {
            return await accountRepository.GetUserByEmailAsync(email);
        }

        public async Task<Cliente> GetUserByIdsync(string id)
        {
            return await accountRepository.GetUserByIdsync(id);
        }

        public async Task<IdentityResult> CreateUserAsync(SignUpModel userModel)
        {
            return await accountRepository.CreateUserAsync(userModel);
        }


        public async Task<SignInResult> PasswordSignInAsync(SignInModel signInModel)
        {
            return await accountRepository.PasswordSignInAsync(signInModel);
        }

        public async Task SignOutAsync()
        {
            await accountRepository.SignOutAsync();
        }

        public async Task CreateAdminRole()
        {
            await accountRepository.CreateAdminRole();
        }

        public async Task AddRoleToUser(string email, string role)
        {
            await accountRepository.AddRoleToUser(email, role);
        }

        public Task<bool> IsAdmin(string email)
        {
            return accountRepository.IsAdmin(email);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return accountRepository.GetClientes();
        }
    }
}
