using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using modelo;
using modelo.entidades;

namespace WebApp.Controllers
{
    public class PresupuestoController : Controller
    {
        private readonly DBLibreria db;
        public PresupuestoController(DBLibreria db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Presupuesto> listaPresupuestos = db.Presupuestos;
            return View(listaPresupuestos);
        }


        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

    }
}
