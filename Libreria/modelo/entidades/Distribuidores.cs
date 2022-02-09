using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public enum ConfirmacionD { Aprobado, Rechazado}


    public class Distribuidores
    {
        public int DistribuidoresId { get; set; }
        public string LibrosD { get; set; }
        public decimal PrecioD { get; set; }
        public string Edicion { get; set; }
        public string Oferta { get; set; }
        public string Editoriales { get; set; }
        public ConfirmacionD ConfirmacionD { get; set; }




        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }


    }
}
