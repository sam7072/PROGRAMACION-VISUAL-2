using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modelo;

namespace WebApp.Controllers
{
    public class CompraController : Controller
    {
        private readonly DBLibreria db;

        public CompraController(DBLibreria db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var listaCompra = db.compras
                .Include(compra => compra.presupuesto);
            

            return View(listaCompra);
        }

        //validar

        public IActionResult Validar (int id)
        {
            var compra = db.compras
                .Include(compra => compra.presupuesto)
                    .ThenInclude(presu => presu.Evaluacion)
                .Include(compra => compra.presupuesto)
                    .ThenInclude(presu => presu.RegistroLibro)
                .Include(compra => compra.presupuesto)
                    .ThenInclude(presu => presu.ReseñaLibro)
                .Include(compra => compra.presupuesto)
                    .ThenInclude(presu => presu.prerequisitos)

                .Single(compra => compra.CompraId == id)
                ;


            return View(compra);
        }


    }
}
