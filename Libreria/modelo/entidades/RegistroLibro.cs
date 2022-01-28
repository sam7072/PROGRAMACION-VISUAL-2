using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class RegistroLibro
    {
        public int RegistroLibroId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Detalles { get; set; }


        public int PresupuestoId { get; set; }
        public Presupuesto Presupuesto { get; set; }



    }
}
