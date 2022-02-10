using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modelo;
using modelo.entidades;
using modelo.operaciones;

namespace Procesos
{
    public class ProPedidosTotal
    {
        readonly DBLibreria db;


        public ProPedidosTotal(DBLibreria db)
        {
            this.db = db;
        }


        //public bool ApruebaPedidos(Presupuesto presupesto)
        //{
        //    CalcDiaPedidos calcDiaPedidos = new CalcDiaPedidos();

        //    var configuracion = db.configuracions.Single();

        //    var tmpPresupuesto = db.Presupuestos
        //        .Include(pre => pre.DemandaLibrerias)
        //        .Include(pre => pre.Distribuidores)
        //        .Single(pre => pre.PresupuestoId == presupesto.PresupuestoId);

        //    var dem = 0;
        //    var distri = tmpPresupuesto.Distribuidores.Count();

        //    var distriLibro = distri * configuracion.LibrosMinimos;

        //    foreach(var bio)

        }

    }
