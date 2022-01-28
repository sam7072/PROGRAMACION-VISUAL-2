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
        public string Pedido { get; set; }
        public DateTime InicioPedido { get; set; }
        public DateTime LimitePedido { get; set; }



        public IList<Prerequisito> prerequisitos { get; set; }


        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }


    }
}
