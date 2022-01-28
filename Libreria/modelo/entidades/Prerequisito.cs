using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class Prerequisito
    {
        public int InventarioId { get; set; }

        public int PresupuestoId { get; set; }


        //relacion 

        
        public Inventario Inventario { get; set; }
        public Presupuesto Presupuesto { get; set; }    



    }
}
