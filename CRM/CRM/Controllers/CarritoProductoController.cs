using CRM.Domain;
using CRM.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    public class CarritoProductoController : Controller
    {
        private ICarritoProductoRepository carritoProductoRepository;
        private IProductoRepository productoRepository;


        public CarritoProductoController(ICarritoProductoRepository carritoProductoRepository, IProductoRepository productoRepository)
        {
            this.carritoProductoRepository = carritoProductoRepository;
            this.productoRepository = productoRepository;
        }

        [Authorize]
        public IActionResult Index()
        {
            var currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var carritos = carritoProductoRepository.Get(x => x.ClienteID == currentUser && x.IdVenta == null).ToList<CarritoProducto>();
            var productos = new List<Producto>();
            foreach (var item in carritos)
            {
                productos.Add(productoRepository.GetById(item.IdProducto));
            }
            return View(productos);
        }

        [Route("PostCarritoCompra")]
        [Authorize]
        [HttpPost]
        public IActionResult PostCarritoCompra(int id)
        {
            var currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var producto = productoRepository.GetById(id);
            CarritoProducto carritoProducto = new CarritoProducto
            {
                ClienteID = currentUser,
                Precio = producto.Precio,
                IdProducto = producto.Id
            };

            carritoProductoRepository.Create(carritoProducto);
            carritoProductoRepository.SaveChanges();
            return RedirectToAction("Index", "CarritoProducto");
        }


        [Route("DeleteCarritoProducto")]
        [Authorize]
        [HttpPost]
        public IActionResult DeleteCarritoProducto(int id)
        {
            var carritoAEliminar = carritoProductoRepository.Get(x => x.IdVenta == null && x.IdProducto == id);
            carritoProductoRepository.Delete(carritoAEliminar.First().Id);
            carritoProductoRepository.SaveChanges();
            return RedirectToAction("Index", "CarritoProducto");
        }
    }
}
