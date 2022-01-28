using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{

    public class DemandaLibreria
    {
        public int DemandalibreriaId { get; set; }
        public string Usuario { get; set; }
        public string Libro { get; set; }
        public DateTime Fechas { get; set; }
        public string ConfirmacionDL { get; set; }



        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }
      
    
    }
}
