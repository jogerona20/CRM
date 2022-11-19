using CRM.Domain;
using CRM.Repository;
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
    }
}
