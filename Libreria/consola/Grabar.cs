using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargaDatos;
using Microsoft.EntityFrameworkCore;
using modeloDB;
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
            var listaConfiguracion = (List<Configuracion>)listas[ListaTipo.Configuracion];


            /*Grabar
            DbContextOptions<DBLibreria> contextOptions;
            contextOptions = new DbContextOptionsBuilder<DBLibreria>()
            .UseSqlServer("server=DESKTOP-R1P6HVR; database=Biblioteca; user id=sa; password=Admin123")
              .Options;


            DBLibreria db = new DBLibreria(contextOptions);
            */

            using (DBLibreria db = DBLibreriaBuilder.Crear())
            {

                db.PreparaDB();

                db.Presupuestos.AddRange(listaPresupuestos);
                db.Inventarios.AddRange(listaInventarios);
                db.prerequisitos.AddRange(listaPrerequisitos);
                db.configuracions.AddRange(listaConfiguracion);


            db.SaveChanges();
            }
        }


    }
}
