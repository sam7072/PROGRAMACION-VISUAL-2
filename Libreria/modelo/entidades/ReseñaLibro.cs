using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public enum CalfLibro { Excelente, buena, malo }

    public class ReseñaLibro
    {

        public int ReseñaLibroId { get; set; }
        public CalfLibro Reseña { get; set; }
        public string Detalles { get; set; }

        public int PresupuestoId { get; set; }
        public Presupuesto presupuesto { get; set; }





    }
}
