using CRM.Models.DTO;
using CRM.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService clienteService;


        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
        [Route("SignIn")]
        public IActionResult SignIn()
        {
            return View();
        }
        [Route("SignUp")]
        public IActionResult SignUp()
        {
            return View();
        }

        [Route("SignUp")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignUpModel userModel)
        {
            if (ModelState.IsValid)
            {
                var result = await clienteService.CreateUserAsync(userModel);
                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }

                    return View(userModel);
                }
                ModelState.Clear();
                return RedirectToAction("SignIn", "Cliente");
            }
            return View(userModel);
        }

        [Route("SignIn")]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInModel signInModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var result = await clienteService.PasswordSignInAsync(signInModel);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Cliente");
                }
                if (result.IsNotAllowed)
                {
                    ModelState.AddModelError("", "Not allowed to login");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid credentials");
                }
            }
            return View(signInModel);
        }

        [Route("SignOut")]
        public async Task<IActionResult> Logout()
        {
            await clienteService.SignOutAsync();
            return RedirectToAction("SignIn", "Cliente");
        }

    }
}
