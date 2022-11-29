using CRM.Domain;
using CRM.Repository;
using CRM.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    public class ProductoController : Controller
    {
        private IProductoRepository productoRepository;
        private readonly IClienteService clienteService;


        public ProductoController(IProductoRepository productoRepository, IClienteService clienteService)
        {
            this.productoRepository = productoRepository;
            this.clienteService = clienteService;
        }
        [Authorize]
        public ActionResult Index()
        {
            var productos = productoRepository.Get().ToList<Producto>();
            return View(productos);
        }

        [Authorize]
        [Route("DeleteProducto")]
        [HttpPost]
        public IActionResult DeleteProducto(int id)
        {
            productoRepository.Delete(id);
            productoRepository.SaveChanges();
            return RedirectToAction("Index", "Producto");
        }

        [Route("Producto/{id:int:min(1)}", Name = "ModificarProducto")]
        [Authorize]
        [HttpPost]
        public IActionResult ModificarProducto(Producto producto)
        {
            if (ModelState.IsValid)
            {
                productoRepository.Update(producto);
                productoRepository.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index", "Producto");
            }
            return RedirectToAction("Index", "Producto");
        }

        [Authorize]
        [Route("Producto/{id:int:min(1)}", Name = "ModificarProducto")]
        public IActionResult ModificarProducto(int id)
        {
            var producto = productoRepository.GetById(id);
            return View(producto);
        }

        [Authorize]
        [Route("RegisterProduct")]
        [HttpPost]
        public IActionResult RegisterProduct(Producto producto)
        {
            if (ModelState.IsValid)
            {
                productoRepository.Create(producto);
                productoRepository.SaveChanges();
                ModelState.Clear();
                var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var currentUser = clienteService.GetUserByIdsync(currentUserId);
                var senderEmail = new MailAddress("geovany_navarro@hotmail.com", "CRM-ADMIN");
                var receiverEmail = new MailAddress(currentUser.Result.Correo,"Receiver");
                var password = "Jogerona12";
                var subject = "Creación de nuevo producto";
                var body = "Nuevo Producto\nId: " + producto.Id + "\nNombre: " + producto.Nombre + "\nDescripción : " + producto.Descripcion + "\nPrecio: $" + producto.Precio;
                var smtp = new SmtpClient
                {
                    Host = "smtp-mail.outlook.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(mess);
                }
                return RedirectToAction("Index", "Producto");
            }
            return View();
        }

        [Route("RegisterProduct")]
        public IActionResult RegisterProduct()
        {
            return View();
        }


    }
}
