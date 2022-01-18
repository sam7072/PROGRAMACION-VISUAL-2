﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modelo;

namespace modeloDB.Migrations
{
    [DbContext(typeof(DBLibreria))]
    partial class DBLibreriaModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("modelo.entidades.DemandaLibreria", b =>
                {
                    b.Property<int>("DemandalibreriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmacionDL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fechas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Libro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DemandalibreriaId");

                    b.HasIndex("PresupuestoId");

                    b.ToTable("DemandaLibrerias");
                });

            modelBuilder.Entity("modelo.entidades.Distribuidores", b =>
                {
                    b.Property<int>("DistribuidoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConfirmacionD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Editoriales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibrosD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oferta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioD")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.HasKey("DistribuidoresId");

                    b.HasIndex("PresupuestoId");

                    b.ToTable("Distribuidores");
                });

            modelBuilder.Entity("modelo.entidades.Inventario", b =>
                {
                    b.Property<int>("InventarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cantidad")
                        .HasColumnType("float");

                    b.Property<string>("Libro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.HasKey("InventarioId");

                    b.HasIndex("PresupuestoId")
                        .IsUnique();

                    b.ToTable("Inventarios");
                });

            modelBuilder.Entity("modelo.entidades.InventarioLibro", b =>
                {
                    b.Property<int>("InventarioLibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EstadoL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InventarioL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioL")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.HasKey("InventarioLibroId");

                    b.HasIndex("PresupuestoId");

                    b.ToTable("InventarioLibros");
                });

            modelBuilder.Entity("modelo.entidades.Presupuesto", b =>
                {
                    b.Property<int>("PresupuestoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CantidadP")
                        .HasColumnType("float");

                    b.Property<string>("Distribuidor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibrosP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PresupuestoId");

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("modelo.entidades.DemandaLibreria", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "presupuesto")
                        .WithMany("DemandaLibrerias")
                        .HasForeignKey("PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.Distribuidores", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "presupuesto")
                        .WithMany("Distribuidores")
                        .HasForeignKey("PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.Inventario", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "presupuesto")
                        .WithOne("Inventario")
                        .HasForeignKey("modelo.entidades.Inventario", "PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.InventarioLibro", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "presupuesto")
                        .WithMany("inventarioLibros")
                        .HasForeignKey("PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.Presupuesto", b =>
                {
                    b.Navigation("DemandaLibrerias");

                    b.Navigation("Distribuidores");

                    b.Navigation("Inventario");

                    b.Navigation("inventarioLibros");
                });
#pragma warning restore 612, 618
        }
    }
}
