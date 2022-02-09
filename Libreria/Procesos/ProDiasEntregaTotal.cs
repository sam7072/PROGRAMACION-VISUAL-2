using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modelo;
using modelo.entidades;

namespace Procesos
{
    public class ProDiasEntregaTotal
    {
        readonly DBLibreria db;

        public ProDiasEntregaTotal(DBLibreria db)
        {
            this.db = db;
        }

        public bool Aprueba(Presupuesto presupuesto)
        {
            var configuracion = db.configuracions.Single();

            var tmpPresupuesto = db.Presupuestos
                .Include(pre => pre.DemandaLibrerias)
                .Include(pre => pre.Distribuidores)
                .Single(pre => pre.PresupuestoId == presupuesto.PresupuestoId);

            var RegistroLibro = tmpPresupuesto.DemandaLibrerias.Count();
            var Distribuidor = tmpPresupuesto.Distribuidores.Count();


            if (Distribuidor < configuracion.LibrosMinimos)
            {
                Distribuidor = Distribuidor + RegistroLibro;  

            }

            if(Distribuidor == configuracion.LibrosMinimos)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
