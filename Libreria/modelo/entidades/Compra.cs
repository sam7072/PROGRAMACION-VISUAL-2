using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public enum CompraEstado { Pendiente, Aprobada, Rechazada }
    public class Compra
    {
        public int CompraId { get; set; }

        [DataType(DataType.Date)]

        public DateTime Fecha { get; set; }
        public CompraEstado CompraEstado { get; set; }


        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }
    }
}
