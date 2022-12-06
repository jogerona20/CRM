using CRM.Domain;
using CRM.Models.DTO;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<Cliente> _userManager;
        private readonly SignInManager<Cliente> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public AccountRepository(UserManager<Cliente> userManager,
            SignInManager<Cliente> signInManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<Cliente> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _userManager.Users;
        }

        public async Task<Cliente> GetUserByIdsync(string id)
        {
            return await _userManager.FindByIdAsync(id);
        }

        public async Task<IdentityResult> CreateUserAsync(SignUpModel userModel)
        {
            var user = new Cliente()
            {
                NombreCompleto = userModel.NombreCompleto,
                Email = userModel.Correo,
                Correo = userModel.Correo,
                Direccion = userModel.Direccion,
                UserName = userModel.Correo,
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }


        public async Task<SignInResult> PasswordSignInAsync(SignInModel signInModel)
        {
            return await _signInManager.PasswordSignInAsync(signInModel.Correo, signInModel.Password, true, false);
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task CreateAdminRole()
        {
            var role = new Microsoft.AspNetCore.Identity.IdentityRole();
            role.Name = "ADMIN";
            await _roleManager.CreateAsync(role);
        }

        public async Task AddRoleToUser(string email, string role)
        {
            var currentUser = _userManager.FindByNameAsync(email);
            await _userManager.AddToRoleAsync(currentUser.Result, role);
        }

        public Task<bool> IsAdmin(string email)
        {
            var currentUser = _userManager.FindByNameAsync(email);
            return Task.FromResult(_userManager.IsInRoleAsync(_userManager.FindByNameAsync(email).Result, "ADMIN").Result);
        }
    }
}
