﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using modelo;

namespace modeloDB.Migrations
{
    [DbContext(typeof(DBLibreria))]
    [Migration("20220208112055_Inicial5")]
    partial class Inicial5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("modelo.entidades.Compra", b =>
                {
                    b.Property<int>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompraEstado")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.HasIndex("PresupuestoId")
                        .IsUnique();

                    b.ToTable("compras");
                });

            modelBuilder.Entity("modelo.entidades.Configuracion", b =>
                {
                    b.Property<string>("NombreDistribuidor")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DiasEntreMinimos")
                        .HasColumnType("int");

                    b.Property<int>("LibrosMinimos")
                        .HasColumnType("int");

                    b.Property<int>("PedidosTotales")
                        .HasColumnType("int");

                    b.HasKey("NombreDistribuidor");

                    b.ToTable("configuracions");
                });

            modelBuilder.Entity("modelo.entidades.DemandaLibreria", b =>
                {
                    b.Property<int>("DemandalibreriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fechas")
                        .HasColumnType("datetime2");

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

                    b.Property<int>("ConfirmacionD")
                        .HasColumnType("int");

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

            modelBuilder.Entity("modelo.entidades.Evaluacion", b =>
                {
                    b.Property<int>("EvaluacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calificaion")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaE")
                        .HasColumnType("datetime2");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.HasKey("EvaluacionId");

                    b.HasIndex("PresupuestoId")
                        .IsUnique();

                    b.ToTable("Evaluacions");
                });

            modelBuilder.Entity("modelo.entidades.Inventario", b =>
                {
                    b.Property<int>("InventarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InicioPedido")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LimitePedido")
                        .HasColumnType("datetime2");

                    b.Property<string>("Pedido")
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

                    b.Property<int>("EstadoL")
                        .HasColumnType("int");

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

            modelBuilder.Entity("modelo.entidades.Prerequisito", b =>
                {
                    b.Property<int>("InventarioId")
                        .HasColumnType("int");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.HasKey("InventarioId", "PresupuestoId");

                    b.HasIndex("PresupuestoId");

                    b.ToTable("prerequisitos");
                });

            modelBuilder.Entity("modelo.entidades.Presupuesto", b =>
                {
                    b.Property<int>("PresupuestoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CantidadP")
                        .HasColumnType("float");

                    b.Property<string>("DistribuidorP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LibrosP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioP")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PresupuestoId");

                    b.ToTable("Presupuestos");
                });

            modelBuilder.Entity("modelo.entidades.RegistroLibro", b =>
                {
                    b.Property<int>("RegistroLibroId")
                        .HasColumnType("int");

                    b.Property<string>("Detalles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.HasKey("RegistroLibroId");

                    b.ToTable("registroLibros");
                });

            modelBuilder.Entity("modelo.entidades.ReseñaLibro", b =>
                {
                    b.Property<int>("ReseñaLibroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PresupuestoId")
                        .HasColumnType("int");

                    b.Property<int>("Reseña")
                        .HasColumnType("int");

                    b.HasKey("ReseñaLibroId");

                    b.HasIndex("PresupuestoId")
                        .IsUnique();

                    b.ToTable("reseñaLibros");
                });

            modelBuilder.Entity("modelo.entidades.Compra", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "presupuesto")
                        .WithOne("Compra")
                        .HasForeignKey("modelo.entidades.Compra", "PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("presupuesto");
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

            modelBuilder.Entity("modelo.entidades.Evaluacion", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "Presupuesto")
                        .WithOne("Evaluacion")
                        .HasForeignKey("modelo.entidades.Evaluacion", "PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presupuesto");
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
                        .WithMany("InventarioLibros")
                        .HasForeignKey("PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.Prerequisito", b =>
                {
                    b.HasOne("modelo.entidades.Inventario", "Inventario")
                        .WithMany("prerequisitos")
                        .HasForeignKey("InventarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("modelo.entidades.Presupuesto", "Presupuesto")
                        .WithMany("prerequisitos")
                        .HasForeignKey("PresupuestoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.RegistroLibro", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "Presupuesto")
                        .WithOne("RegistroLibro")
                        .HasForeignKey("modelo.entidades.RegistroLibro", "RegistroLibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.ReseñaLibro", b =>
                {
                    b.HasOne("modelo.entidades.Presupuesto", "presupuesto")
                        .WithOne("ReseñaLibro")
                        .HasForeignKey("modelo.entidades.ReseñaLibro", "PresupuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("presupuesto");
                });

            modelBuilder.Entity("modelo.entidades.Inventario", b =>
                {
                    b.Navigation("prerequisitos");
                });

            modelBuilder.Entity("modelo.entidades.Presupuesto", b =>
                {
                    b.Navigation("Compra");

                    b.Navigation("DemandaLibrerias");

                    b.Navigation("Distribuidores");

                    b.Navigation("Evaluacion");

                    b.Navigation("Inventario");

                    b.Navigation("InventarioLibros");

                    b.Navigation("prerequisitos");

                    b.Navigation("RegistroLibro");

                    b.Navigation("ReseñaLibro");
                });
#pragma warning restore 612, 618
        }
    }
}
