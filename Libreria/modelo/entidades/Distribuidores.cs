using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class Distribuidores
    {
        public int DistribuidoresId { get; set; }
        public string LibrosD { get; set; }
        public decimal PrecioD { get; set; }
        public string Edicion { get; set; }
        public string Oferta { get; set; }
        public string Editoriales { get; set; }
        public string ConfirmacionD { get; set; }




        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }


    }
}
