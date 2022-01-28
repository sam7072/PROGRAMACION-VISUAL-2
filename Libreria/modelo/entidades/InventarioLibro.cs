using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class InventarioLibro
    {
        public int InventarioLibroId { get; set; }
        public string InventarioL { get; set; }
        public string EstadoL { get; set; }
        public decimal PrecioL { get; set; }


       

        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }
    }
}
