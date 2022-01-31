using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using modelo;
using modelo.entidades;

namespace WebApp.Controllers
{
    public class DemandaLibreriaController : Controller
    {
        private readonly DBLibreria db;

        public DemandaLibreriaController(DBLibreria db)
        {
            this.db = db;
        }

        //vista
        public IActionResult Index()
        {
            IEnumerable<DemandaLibreria> listademandaLibrerias = db.DemandaLibrerias;
            return View(listademandaLibrerias);

        }

        //crear

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DemandaLibreria demandaLibreria)
        {
            //Grabar
            db.DemandaLibrerias.Add(demandaLibreria);
            db.SaveChanges();

            TempData["mensaje"] = $"Grabado {demandaLibreria.Usuario} exitosamente";


            return RedirectToAction("Index");
        }

        //editar
        [HttpGet]
        public IActionResult Edit(int id)
        {
            DemandaLibreria demandaLibreria = db.DemandaLibrerias.Find(id);
            return View(demandaLibreria);
        }

        [HttpPost]
        public IActionResult Edit(DemandaLibreria demandaLibreria)
        {
            //Grabar
            db.DemandaLibrerias.Update(demandaLibreria);
            db.SaveChanges();

            TempData["mensaje"] = $"Actualizada {demandaLibreria.Usuario} exitosamente";


            return RedirectToAction("Index");
        }


        //Eliminar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            DemandaLibreria demandaLibreria = db.DemandaLibrerias.Find(id);

            return View(demandaLibreria);
        }

        [HttpPost]
        public IActionResult Delete(DemandaLibreria demandaLibreria)
        {
            db.DemandaLibrerias.Remove(demandaLibreria);
            db.SaveChanges();

            TempData["mensaje"] = $"Eliminada/o  {demandaLibreria.Usuario} exitosamente";
            return RedirectToAction("Index");
        }


    }
}
