﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(APItiendaContext))]
    partial class APItiendaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("NombreEstado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Estado", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaNac")
                        .HasColumnType("Date");

                    b.Property<int>("IdPersona")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPer")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPersona")
                        .IsUnique();

                    b.HasIndex("IdTipoPer");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CodInterno")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.Property<double>("ValorVta")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Producto", (string)null);
                });

            modelBuilder.Entity("Core.Entities.ProductoPersona", b =>
                {
                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.HasKey("IdPersona", "IdProducto");

                    b.HasIndex("IdProducto");

                    b.ToTable("ProductoPersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadoFk");

                    b.ToTable("Region", (string)null);
                });

            modelBuilder.Entity("Core.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("TipoPersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.HasOne("Core.Entities.Pais", "Pais")
                        .WithMany("Estados")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.HasOne("Core.Entities.TipoPersona", "TipoPersona")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Core.Entities.ProductoPersona", b =>
                {
                    b.HasOne("Core.Entities.Persona", "Persona")
                        .WithMany("ProductosPersonas")
                        .HasForeignKey("IdPersona")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Producto", "Producto")
                        .WithMany("ProductosPersonas")
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Core.Entities.Region", b =>
                {
                    b.HasOne("Core.Entities.Estado", "Estado")
                        .WithMany("Regiones")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Core.Entities.Estado", b =>
                {
                    b.Navigation("Regiones");
                });

            modelBuilder.Entity("Core.Entities.Pais", b =>
                {
                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Core.Entities.Persona", b =>
                {
                    b.Navigation("ProductosPersonas");
                });

            modelBuilder.Entity("Core.Entities.Producto", b =>
                {
                    b.Navigation("ProductosPersonas");
                });

            modelBuilder.Entity("Core.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}