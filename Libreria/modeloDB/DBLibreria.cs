﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modelo.entidades;


namespace modelo
{
    public class DBLibreria:DbContext
    {
        public DbSet<DemandaLibreria> DemandaLibrerias { get; set; }
        public DbSet<Distribuidores> Distribuidores { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }  
        public DbSet<InventarioLibro> InventarioLibros { get; set; }    
        public DbSet<Presupuesto> Presupuestos { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connSQL = "server=DESKTOP-R1P6HVR; database=Biblioteca; user id=sa; password=Admin123";


            optionsBuilder.UseSqlServer(connSQL);
        
        }

        }
}
