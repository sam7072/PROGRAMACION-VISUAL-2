using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public class Evaluacion
    {
        public DateTime FechaE { get; set; }
        public string Calificaion { get; set; }


        public int PresupuestoId { get; set; }
        public Presupuesto Presupuesto { get; set; }


    }
}
