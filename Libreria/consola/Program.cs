using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using modelo.entidades;

namespace consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
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



        }
    }
}
