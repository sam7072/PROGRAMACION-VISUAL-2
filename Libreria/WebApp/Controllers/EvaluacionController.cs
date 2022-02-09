using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using modelo;
using modelo.entidades;

namespace WebApp.Controllers
{
    public class EvaluacionController : Controller
    {
        private readonly DBLibreria db;

        public EvaluacionController(DBLibreria db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Evaluacion> listaEvaluaciones = db.Evaluacions;
            return View(listaEvaluaciones);
        }


        //crear una evaluacion

        [HttpGet]
        public IActionResult Create()
        {
            //lista Presupuestos
            var listaPresupuestos = db.Presupuestos
                .Select(presupuesto => new
                 {
                    PresupuestoId =presupuesto.PresupuestoId,
                    Libro = presupuesto.LibrosP

                 }).ToList();

            //preparar listas
            var selectListaPresupuestos = new SelectList(listaPresupuestos, "PresupuestoId", "Libro");

            //ingreso Viebag
            ViewBag.selectListPresupuestos = selectListaPresupuestos;
            return View();
          }

        [HttpPost]
        public IActionResult Create(Evaluacion evaluacion)
        {
            //Grabar Evaluacion
            db.Evaluacions.Add(evaluacion);
            db.SaveChanges();
            TempData["mensaje"] = $"La evaluacion {evaluacion.FechaE} creado exitosamente";
            return RedirectToAction("Index");
        }




        //edicion de evaluacion
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //lista de Presupuestos
            var listaPresupuestos = db.Presupuestos
                .Select(presupuesto => new
                {
                    PresupuestoId = presupuesto.PresupuestoId,
                    Libro = presupuesto.LibrosP

                }).ToList();

            //preparar listas
            var selectListaPresupuestos = new SelectList(listaPresupuestos, "PresupuestoId", "Libro");


            //ingreso viabag
            ViewBag.selectListPresupuestos = selectListaPresupuestos;
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            return View(evaluacion);

        }

        [HttpPost]
        public IActionResult Edit(Evaluacion evaluacion)
        {
            //grabar
            db.Evaluacions.Update(evaluacion);
            db.SaveChanges();


            TempData["mensaje"] = $"La evaluacion  {evaluacion.FechaE} ha sido actualizado exitosamente";
            return RedirectToAction("Index");

        }



        //borrar
        [HttpGet]
        public IActionResult Delete(int id)
        {
            //lista
            var listaPresupuestos = db.Presupuestos
                .Select(presupuesto => new
                {
                    PresupuestoId = presupuesto.PresupuestoId,
                    Libro = presupuesto.LibrosP

                }).ToList();
            //preparar
            var selectListaPresupuestos = new SelectList(listaPresupuestos, "PresupuestoId", "Libro");


            //ingreso viebag
            ViewBag.selectListEmpleados = selectListaPresupuestos;
            Evaluacion evaluacion = db.Evaluacions.Find(id);
            return View(evaluacion);

        }

        //borrar
        public IActionResult Delete(Evaluacion evaluacion)
        {
            //Grabar Evaluacion
            db.Evaluacions.Remove(evaluacion);
            db.SaveChanges();

            TempData["mensaje"] = $"La evaluacion {evaluacion.FechaE} ha sido eliminado exitosamente";
            return RedirectToAction("Index");
        }
        }
    }
