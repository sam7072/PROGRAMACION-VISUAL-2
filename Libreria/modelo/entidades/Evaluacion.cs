using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.entidades
{
    public enum Calificaion { Buena, Regular, Mala }

    public class Evaluacion
    {
        public int EvaluacionId {get; set;}

        [DataType(DataType.Date)]
        public DateTime FechaE { get; set; }
        public Calificaion Calificaion { get; set; }


        public int PresupuestoId { get; set; }
        public Presupuesto Presupuesto { get; set; }


    }
}
