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
        //configurar el modelo de objetos
        protected override void OnModelCreating(ModelBuilder model)
        {
            //Cardinalidad de las clases 

            model.Entity<DemandaLibreria>()
                .HasOne(Dem => Dem.presupuesto)
                .WithMany(Pre => Pre.DemandaLibrerias)
                .HasForeignKey(Dem => Dem.PresupuestoId);


            model.Entity<Distribuidores>()
                .HasOne(Dis => Dis.presupuesto)
                .WithMany(Pre => Pre.Distribuidores)
                .HasForeignKey(Dis => Dis.PresupuestoId);




            //Configuracion 
            model.Entity<InventarioLibro>()
                .HasOne(inventario => inventario.presupuesto)
                .WithMany(lib => lib.inventarioLibros)
                .HasForeignKey(inventario => inventario.PresupuestoId);





            /* cardinalidad 1 a 1
            model.Entity<Inventario>()
            .HasOne
            */




            /*

            // configurar el modelo de clases 
            model.Entity<Configuracion>()
                .HasNokey();
            //periodo 
            model.Entity<Configuracion>()
                .HasOne(Confi => Confi.PeriodoVigente)
                .WithMany()
                .HasForeignKey(Confi => Confi.PeriodoVigente);



            //Prerequisitos
            //Malla
            model.Entity<Prerequisito>()
                .HasOne(prerequisito => prerequisito.Prerequisito)
                .WithMany(malla => malla.Prerequisitos)
                .HasForeignKey(prerequisito => prerequisito.MallaId);

            //Materia
            model.Entity<Prerequisito>()
                .HasOne(prerequisito => prerequisito.Prerequisito)
                .WithMany(materia => materia.Prerequisitos)
                .HasForeignKey(prerequisito => prerequisito.MateriaId);


            //clave primaria formada por dos claves foreneas
            model.Entity<Prequisitos>()
                .HasKey(prerequisito => new
                {
                    prerequisito.MallaId,
                    prerequisito.MateriaId
                });

            //Matricula Det
            //-calificacion
            model.Entity<Matricula_Det>()
                .HasOne(matricula_det => matricula_det.calificaciones)
                .WithOne(calificacion => calificacion.Matricula_det)
                .HasForeignKey<Calificacion>(calificacion => calificacion.Matricula_detID);


            //malla-materia
            // de one a one
            model.Entity<Malla>()
                .HasOne(malla => malla.Materia)
                .WithMany(materia => materia.Malla)
                .HasForeignKey<Malla>(malla => malla.MateriaId);


            //-carrera
            model.Entity<Malla>()
                .HasOne(malla => malla.Carrera)
                .WithMany()
                .HasForeignKey(malla => malla.CarreraID);

            */





        }





    }
}
