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


        //crear

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(InventarioLibro inventarioLibro)
        {
            //Grabar
            db.InventarioLibros.Add(inventarioLibro);
            db.SaveChanges();

            TempData["mensaje"] = $"Grabado {inventarioLibro.InventarioL} exitosamente";


            return RedirectToAction("Index");
        }





    }
}
