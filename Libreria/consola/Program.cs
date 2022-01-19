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
            Inventario in1 = new Inventario()
            {
                Libro = "Mago de oz",
                Cantidad = 10,
                Motivo = "Repositorio"
                
            };

            Distribuidores dis1 = new Distribuidores()
            {
                LibrosD = "Mago de oz",
                PrecioD = 15.00M,
                Edicion = "2001",
                Oferta = "50%",
                Editoriales = "Libreria Cientifica",
                ConfirmacionD = "Aprobada"

             };

            DemandaLibreria dem1 = new DemandaLibreria()
            {
                Usuario = "Luis",
                Libro = "Mago de oz",
                Fechas = "12/12/2012",
                ConfirmacionDL = "Aprobada"


            };

            InventarioLibro inL1 = new InventarioLibro()
            {
                InventarioL = "Mago de oz 1",
                EstadoL = "Bueno",
                PrecioL = 15.00M
                

            };



            Presupuesto primerLibro = new Presupuesto()
            {
                LibrosP = "mago de oz",
                Precio = 15.00M,
                CantidadP = 10,
                Distribuidor = "Libreria Cientifica",
                Inventario = new Inventario(),
                Distribuidores = new List<Distribuidores>() { new Distribuidores() { } },
                DemandaLibrerias = new List<DemandaLibreria> { new DemandaLibreria() { } }, 
                inventarioLibros = new List<InventarioLibro>() { new InventarioLibro() { } } 


            };


            DBLibreria r = new DBLibreria();
            r.Presupuestos.Add(primerLibro);
            r.SaveChanges();



        }
    }
}
