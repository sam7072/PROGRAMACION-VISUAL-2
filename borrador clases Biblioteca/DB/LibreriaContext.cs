using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using borrador_clases_Biblioteca.LIbreria_Distribuidora;
using Microsoft.EntityFrameworkCore;

namespace borrador_clases_Biblioteca.DB
{
    public class LibreriaContext : DbContext

    {
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<InventarioLibro> InventarioLibros { get; set; }
        public DbSet<DemandaLibreria> DemandaLibrerias { get; set; }
        public DbSet<Distribuidores> Distribuidores { get; set; }

    }
}
