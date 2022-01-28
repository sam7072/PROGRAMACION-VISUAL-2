using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class Presupuesto
    {
        public int PresupuestoId { get; set; }
        public string LibrosP { get; set; }
        public decimal PrecioP { get; set; }
        public double CantidadP { get; set; }
        public string DistribuidorP { get; set; }




        //relacion distribuidores
        public List<Distribuidores> Distribuidores { get; set;}
        //relacion DemandaLibreria
        public List<DemandaLibreria> DemandaLibrerias { get; set; }
        //relacion InventarioLibro
        public List<InventarioLibro> InventarioLibros { get; set; }  
        //relacion inventario
        public Inventario Inventario { get; set; }
        //relacion evaluacion
        public Evaluacion Evaluacion { get; set; }
        //relacion RegistroLibro
        public RegistroLibro RegistroLibro { get; set; }

        //relacion prerequisito
        public IList<Prerequisito> prerequisitos { get; set; }


    }
}
