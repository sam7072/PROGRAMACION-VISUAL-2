using System;
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
        //Constructor invoca del padre
        public DBLibreria(DbContextOptions<DBLibreria> options)
            :base(options)
        {

        }






        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<DemandaLibreria> DemandaLibrerias { get; set; }
        public DbSet<Distribuidores> Distribuidores { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }  
        public DbSet<InventarioLibro> InventarioLibros { get; set; }    
        public DbSet<Evaluacion> Evaluacions { get; set; }
        public DbSet<RegistroLibro> registroLibros { get; set; }
        public DbSet<Prerequisito> prerequisitos { get; set; }



        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connSQL = "server=DESKTOP-R1P6HVR; database=Biblioteca; user id=sa; password=Admin123";


            optionsBuilder.UseSqlServer(connSQL);
        
        }*/
        //configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Cardinalidad de las clases 


            //demanda-presupuesto
            model.Entity<DemandaLibreria>()
                .HasOne(Dem => Dem.presupuesto)
                .WithMany(Pre => Pre.DemandaLibrerias)
                .HasForeignKey(Dem => Dem.PresupuestoId);

            //distribuidores-presupuesto
            model.Entity<Distribuidores>()
                .HasOne(Dis => Dis.presupuesto)
                .WithMany(Pre => Pre.Distribuidores)
                .HasForeignKey(Dis => Dis.PresupuestoId);

            //inventarioLibro-presupuesto
            model.Entity<InventarioLibro>()
                .HasOne(inventarioL => inventarioL.presupuesto)
                .WithMany(lib => lib.InventarioLibros)
                .HasForeignKey(inventarioL => inventarioL.PresupuestoId);





            //presupuesto - RegistroLibro
            model.Entity<Presupuesto>()
                .HasOne(presupuesto => presupuesto.RegistroLibro)
                .WithOne(regis => regis.Presupuesto)
                .HasForeignKey<RegistroLibro>(regis => regis.RegistroLibroId);

            //presupuesto - inventario 
            model.Entity<Presupuesto>()
                .HasOne(presupuesto => presupuesto.Inventario)
                .WithOne(inv => inv.presupuesto)
                .HasForeignKey<Inventario>(inventario => inventario.PresupuestoId);

            //presupuesto - Evaluacion
            model.Entity<Presupuesto>()
                .HasOne(presupuesto => presupuesto.Evaluacion)
                .WithOne(evaluacion => evaluacion.Presupuesto)
                .HasForeignKey<Evaluacion>(evaluacion => evaluacion.PresupuestoId);



            //inventario
            model.Entity<Prerequisito>()
                .HasOne(prerequisito => prerequisito.Inventario)
                .WithMany(inve => inve.prerequisitos)
                .HasForeignKey(prerequisito => prerequisito.InventarioId);

            //inventarioLibro
            model.Entity<Prerequisito>()
                .HasOne(prerequisito => prerequisito.Presupuesto)
                .WithMany(pre => pre.prerequisitos)
                .HasForeignKey(prerequisito => prerequisito.PresupuestoId);


            //clave primario formada por 2 foreaneas
            model.Entity<Prerequisito>()
                .HasKey(prerequisito => new { prerequisito.InventarioId, prerequisito.PresupuestoId });



        }





    }
}
