using CRM.Domain;
using CRM.Repository;
using Microsoft.AspNetCore.Mvc;
using Rotativa;
using Rotativa.AspNetCore;
using System;
using CRM.DTO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace CRM.Controllers
{
    public class EmpleadoController : Controller
    {
        private IEmpleadoRepository empleadoRepository;

        public EmpleadoController(IEmpleadoRepository empleadoRepository)
        {
            this.empleadoRepository = empleadoRepository;
        }

        public ActionResult Index()
        {
            var empleados = empleadoRepository.All().ToList();
            return View(empleados);
        }

        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                empleado.FechaIngreso = DateTime.Now;
                empleadoRepository.Create(empleado);
                empleadoRepository.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index", "Empleado");
            }
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult DeleteEmpleado(int id)
        {
            empleadoRepository.Delete(id);
            empleadoRepository.SaveChanges();
            return RedirectToAction("Index", "Empleado");
        }

        [Authorize]
        [Route("Empleado/{id:int:min(1)}", Name = "Update")]
        [HttpPost]
        public ActionResult Update(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                empleadoRepository.Update(empleado);
                empleadoRepository.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("Index", "Empleado");
            }
            return View();
        }

        [Authorize]
        [Route("Empleado/{id:int:min(1)}", Name = "Update")]
        public ActionResult Update(int id)
        {
            var empleado = empleadoRepository.GetById(id);
            return View(empleado);
        }

        [Authorize]
        public ActionResult PrintNomina(Nomina nomina, int id)
        {
            var empleado = empleadoRepository.GetById(id);
            nomina.empleado = empleado;
            nomina.CalcularNomina();
            return new ViewAsPdf("PrintNomina", nomina);
        }

        [Authorize]
        public ActionResult Nomina(int id)
        {
            var empleado = empleadoRepository.GetById(id);
            var nomina = new Nomina();
            nomina.empleado = empleado;
            return View(nomina);
        }

    }
}
    