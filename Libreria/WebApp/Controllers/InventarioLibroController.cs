using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using modelo;
using modelo.entidades;

namespace WebApp.Controllers
{
    public class InventarioLibroController : Controller
    {

        private readonly DBLibreria db;

        public InventarioLibroController(DBLibreria db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<InventarioLibro> listaInventarioLibros = db.InventarioLibros;
            return View(listaInventarioLibros);
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
