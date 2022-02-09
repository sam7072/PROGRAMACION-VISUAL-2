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

        //creación presupuesto
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create( Presupuesto presupuesto)
        {
            //Grabar presupuesto
            db.Presupuestos.Add(presupuesto);
            db.SaveChanges();
            TempData["mensaje"] = $"El Presupuesto {presupuesto.LibrosP} creado exitosamente";

            return RedirectToAction("Index");
        }



        //edicion Presupuesto
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Presupuesto presupuesto = db.Presupuestos.Find(id);
            return View(presupuesto);
        
        }
        [HttpPost]
        public IActionResult Edit(Presupuesto presupuesto)
        {
            //Grabar presupuesto
            db.Presupuestos.Update(presupuesto);
            db.SaveChanges();

            TempData["mensaje"] = $"El Presupuesto {presupuesto.LibrosP} ha sido actualizado exitosamente";
            return RedirectToAction("Index");
        }






        //borrar Presupuesto
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Presupuesto presupuesto = db.Presupuestos.Find(id);
            return View(presupuesto);


        }

        [HttpPost]
        public IActionResult Delete( Presupuesto presupuesto)
        {
            //Grabar presupuesto
            db.Presupuestos.Remove(presupuesto);
            db.SaveChanges();

            TempData["mensaje"] = $"El presupuesto {presupuesto.LibrosP} ha sido eliminado exitosamente";
            return RedirectToAction("Index");

        }


        }
}
