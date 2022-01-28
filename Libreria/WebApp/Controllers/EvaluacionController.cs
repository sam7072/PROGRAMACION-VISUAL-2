using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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
