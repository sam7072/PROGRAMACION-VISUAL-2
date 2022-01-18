using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class Inventario
    {
        public int InventarioId { get; set; }
        public string Libro { get; set; }
        public double Cantidad { get; set; }
        public string Motivo { get; set; }




        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }


    }
}
