using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using modelo;
using modelo.entidades;

namespace consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Grabar grabar = new Grabar();
            grabar.DatosIni();


            using (var db = DBLibreriaBuilder.Crear())
            {
                var listaPresupuestos = db.Presupuestos
                    .Include(presupuesto => presupuesto.Evaluacion)
                    .Include(presupuesto => presupuesto.ReseñaLibro);


                Console.WriteLine("Listado de Presupuesto");
                foreach (var presupuesto in listaPresupuestos)
                {
                    Console.WriteLine(
                        presupuesto.LibrosP + " " +
                        presupuesto.PrecioP + " " +
                        presupuesto.CantidadP + " " +
                        presupuesto.DistribuidorP + " " +
                        "Evaluacion: " + presupuesto.Evaluacion.Calificaion +
                        "Reseña Del libro: " + presupuesto.ReseñaLibro.Reseña
                        
                        );
                }


                var listaInventario = db.Inventarios;

                Console.WriteLine("Lista de Inventario");
                foreach (var inventario in listaInventario)
                {
                    Console.WriteLine(
                        inventario.Pedido + " " +
                        inventario.InicioPedido.ToLongTimeString() +
                        inventario.LimitePedido.ToLongTimeString()
                        );
                }

                var listaPrerequisito = db.prerequisitos
                    .Include(prerequisitos => prerequisitos.Inventario)
                    .Include(prerequisitos => prerequisitos.Presupuesto);


                Console.WriteLine("Lista de Prerequisitos");
                foreach (var prerequisitos in listaPrerequisito)
                {
                    Console.WriteLine(
                        prerequisitos.Inventario.Pedido + " " +
                        prerequisitos.Presupuesto.LibrosP + " " +
                        prerequisitos.Inventario.InicioPedido + " " +
                        prerequisitos.Inventario.LimitePedido
                        );
                }




            }
            


            /*DBLibreria r = new DBLibreria();
            r.Presupuestos.Add(primerLibro);
            r.SaveChanges();
            */


        }
    }
}
