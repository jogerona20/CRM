using CRM.Domain;
using CRM.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    public class ProductoController : Controller
    {
        private IProductoRepository productoRepository;

        public ProductoController(IProductoRepository productoRepository)
        {
            this.productoRepository = productoRepository;
        }
        public ActionResult Index()
        {
            var productos = productoRepository.Get().ToList<Producto>();
            return View(productos);
        }

        [Route("DeleteProducto")]
        [HttpPost]
        public IActionResult DeleteProducto(int id)
        {
            productoRepository.Delete(id);
            productoRepository.SaveChanges();
            return RedirectToAction("Index", "Producto");
        }

        [Route("RegisterProduct")]
        [HttpPost]
        public IActionResult RegisterProduct(Producto producto)
        {
            if (ModelState.IsValid)
            {
                productoRepository.Create(producto);
                productoRepository.SaveChanges();
                ModelState.Clear();
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
