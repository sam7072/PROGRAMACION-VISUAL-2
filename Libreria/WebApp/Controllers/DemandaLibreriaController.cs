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


        public IActionResult Index()
        {
            IEnumerable<DemandaLibreria> listademandaLibrerias = db.DemandaLibrerias;
            return View(listademandaLibrerias);

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
