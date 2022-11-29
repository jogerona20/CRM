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

        [Authorize]
        public IActionResult Index()
        {
            var currentUser = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var ventas = ventaReposiory.Get(x => x.ClienteId == currentUser).ToList<Venta>();
            return View(ventas);
        }

        [Authorize]
        [Route("Venta/{id:int:min(1)}", Name = "Venta")]
        public IActionResult Venta(int id)
        {
            var venta = ventaReposiory.GetById(id);
            return View(venta);
        }

        [Route("ActualizaEnvio/{id:int:min(1)}", Name = "ActualizaEnvio")]
        [HttpPost]
        [Authorize]
        public IActionResult ActualizaEnvio(int id)
        {
            var venta = ventaReposiory.GetById(id);
            switch (venta.EstatusEnvio)
            {
                case "Ordenado":
                    venta.EstatusEnvio = "Enviado";
                    break;
                case "Enviado":
                    venta.EstatusEnvio = "En Camino";
                    break;
                case "En Camino":
                    venta.EstatusEnvio = "Entregado";
                    break;
                default:
                    return RedirectToAction("Venta", "Venta", new { id = id });
            }
            ventaReposiory.Update(venta);
            ventaReposiory.SaveChanges();
            return RedirectToAction("Venta", "Venta", new { id = id });
        }

        [Route("PostVenta")]
        [Authorize]
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
                EstatusEnvio = "Ordenado",
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
            return RedirectToAction("Index", "Venta");
        }
    }
}
