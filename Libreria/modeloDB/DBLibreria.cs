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
        public DBLibreria()
        {

        }
        //Constructor invoca del padre
        public DBLibreria(DbContextOptions<DBLibreria> options)
            :base(options)
        {
            
        }
        // Se asegura el borrado y la creación de la base de datos
        public void PreparaDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }





        public DbSet<Presupuesto> Presupuestos { get; set; }
        public DbSet<DemandaLibreria> DemandaLibrerias { get; set; }
        public DbSet<Distribuidores> Distribuidores { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }  
        public DbSet<InventarioLibro> InventarioLibros { get; set; }    
        public DbSet<Evaluacion> Evaluacions { get; set; }
        public DbSet<RegistroLibro> registroLibros { get; set; }
        public DbSet<Prerequisito> prerequisitos { get; set; }
        public DbSet<Compra> compras { get; set; }
        public DbSet<Configuracion> configuracions { get; set; }
        public DbSet<ReseñaLibro> reseñaLibros { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Si no se ha configurado la conección la configura con SqlServer
            if (!options.IsConfigured)
            {
                options.UseSqlServer("server=DESKTOP-R1P6HVR;database=LibreriaWEB;user id=Sa; password=Admin123");
                // .LogTo(Console.WriteLine, LogLevel.Information);  // Para activar el modo debug
            }
        }
        //configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Cardinalidad de las clases 


            //clase Configuracion Pk distinta a entero
            model.Entity<Configuracion>()
                .HasKey(configuracion => configuracion.NombreDistribuidor);

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
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(prerequisito => prerequisito.InventarioId);

            //Presupuesto
            model.Entity<Prerequisito>()
                .HasOne(prerequisito => prerequisito.Presupuesto)
                .WithMany(pre => pre.prerequisitos)
                .OnDelete(DeleteBehavior.NoAction)
                .HasForeignKey(prerequisito => prerequisito.PresupuestoId);


            //clave primario formada por 2 foreaneas
            model.Entity<Prerequisito>()
                .HasKey(prerequisito => new { prerequisito.InventarioId, prerequisito.PresupuestoId });



        }





    }
}
