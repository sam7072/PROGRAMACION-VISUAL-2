using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargaDatos;
using modelo;
using modelo.entidades;
using static CargaDatos.DatosIniciales;

namespace consola
{
    internal class Grabar
    {
        public void DatosIni()
        {
            DatosIniciales datos = new DatosIniciales();
            var listas = datos.Carga();

            //extraer listas
            var listaInventarios = (List<Inventario>)listas[ListaTipo.Iventarios];
            var listaPresupuestos = (List<Presupuesto>)listas[ListaTipo.Presupuestos];
            var listaPrerequisitos = (List<Prerequisito>)listas[ListaTipo.Prerequisitos];



            //Grabar
            DBLibreria db = new DBLibreria();

            db.Presupuestos.AddRange(listaPresupuestos);
            db.Inventarios.AddRange(listaInventarios);
            db.prerequisitos.AddRange(listaPrerequisitos);


            db.SaveChanges();
        }


    }
}
