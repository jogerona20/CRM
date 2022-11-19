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
    }
}
