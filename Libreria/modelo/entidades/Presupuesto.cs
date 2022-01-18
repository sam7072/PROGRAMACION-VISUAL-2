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
        public decimal Precio { get; set; }
        public double CantidadP { get; set; }
        public string Distribuidor { get; set; }


        public List<Distribuidores> Distribuidores { get; set;}
        public List<DemandaLibreria> DemandaLibrerias { get; set; }
        public List<InventarioLibro> inventarioLibros { get; set; }  

        public Inventario Inventario { get; set; }  



    }
}
