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
    public class VentaController : Controller
    {
        private readonly IVentaRepository ventaReposiory;
        private ICarritoProductoRepository carritoProductoRepository;
        private IProductoRepository productoRepository;


        public VentaController(IVentaRepository ventaRepository, ICarritoProductoRepository carritoProductoRepository, IProductoRepository productoRepository)
        {
            this.ventaReposiory = ventaRepository;
            this.carritoProductoRepository = carritoProductoRepository;
            this.productoRepository = productoRepository;
        }

        public IActionResult Index()
        {
            var currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ventas = ventaReposiory.Get(x => x.ClienteId == currentUser).ToList<Venta>();
            return View(ventas);
        }

        [Route("PostVenta")]
        [HttpPost]
        public IActionResult PostVenta()
        {
            var currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var carritos = carritoProductoRepository.Get(x => x.ClienteID == currentUser && x.IdVenta == null).ToList<CarritoProducto>();
            var productos = new List<Producto>();
            float importe = 0;
            foreach (var item in carritos)
            {
                productos.Add(productoRepository.GetById(item.IdProducto));
            }
            foreach (var item in productos)
            {
                importe += (float)item.Precio;   
            }
            Venta venta = new Venta{
                ClienteId = currentUser,
                Importe = importe,
                EstatusEnvio = "En espera",
                Fecha = DateTime.Now
            };

            ventaReposiory.Create(venta);
            ventaReposiory.SaveChanges();
            var ultimaVenta = ventaReposiory.Get(x => x.Fecha == venta.Fecha).ToList();

            foreach (var item in carritos)
            {
                item.IdVenta = ultimaVenta.FirstOrDefault().Id;
                carritoProductoRepository.Update(item);
            }
            carritoProductoRepository.SaveChanges();
            return RedirectToAction("Index", "Producto");
        }
    }
}
