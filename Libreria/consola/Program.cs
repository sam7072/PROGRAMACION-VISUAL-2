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
            

            /*DBLibreria r = new DBLibreria();
            r.Presupuestos.Add(primerLibro);
            r.SaveChanges();
            */


        }
    }
}
