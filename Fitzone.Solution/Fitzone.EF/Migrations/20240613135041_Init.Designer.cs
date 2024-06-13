﻿// <auto-generated />
using System;
using Fitzone.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fitzone.EF.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240613135041_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fitzone.Entidades.Barrio", b =>
                {
                    b.Property<int>("idBarrio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idBarrio"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("idBarrio");

                    b.ToTable("Barrio");
                });

            modelBuilder.Entity("Fitzone.Entidades.Configuraciones", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("valor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Configuraciones");
                });

            modelBuilder.Entity("Fitzone.Entidades.Cuota", b =>
                {
                    b.Property<int>("idCuota")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCuota"));

                    b.Property<DateTime>("fechaDesde")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaHasta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaVencimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("idMembresia")
                        .HasColumnType("int");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("idCuota");

                    b.HasIndex("idMembresia");

                    b.ToTable("Cuota");
                });

            modelBuilder.Entity("Fitzone.Entidades.EstadoMembresia", b =>
                {
                    b.Property<int>("idEstadoMembresia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idEstadoMembresia"));

                    b.Property<string>("descripcion")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("idEstadoMembresia");

                    b.ToTable("EstadoMembresia");
                });

            modelBuilder.Entity("Fitzone.Entidades.Membresia", b =>
                {
                    b.Property<int>("idMembresia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idMembresia"));

                    b.Property<int>("cantidadDiasSemanales")
                        .HasColumnType("int");

                    b.Property<string>("detalle")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("diasHabilitados")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaDesde")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaHasta")
                        .HasColumnType("datetime2");

                    b.Property<int>("idEstadoMembresia")
                        .HasColumnType("int");

                    b.Property<int>("idSocio")
                        .HasColumnType("int");

                    b.Property<int>("idTipoMembresia")
                        .HasColumnType("int");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("idMembresia");

                    b.HasIndex("idEstadoMembresia");

                    b.HasIndex("idSocio");

                    b.HasIndex("idTipoMembresia");

                    b.ToTable("Membresia");
                });

            modelBuilder.Entity("Fitzone.Entidades.Socio", b =>
                {
                    b.Property<int>("idSocio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idSocio"));

                    b.Property<bool>("anulado")
                        .HasColumnType("bit");

                    b.Property<string>("apellido")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("calle")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("calleNumero")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("idBarrio")
                        .HasColumnType("int");

                    b.Property<byte[]>("imagen")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("mail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("numeroDocumento")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("telefono1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("telefono2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("tipoDocumento")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("idSocio");

                    b.HasIndex("idBarrio");

                    b.ToTable("Socio");
                });

            modelBuilder.Entity("Fitzone.Entidades.TipoMembresia", b =>
                {
                    b.Property<int>("idTipoMembresia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idTipoMembresia"));

                    b.Property<int>("cantidadCuotas")
                        .HasColumnType("int");

                    b.Property<int>("cantidadDiasSemanales")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("diasHabilitados")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("precioTotal")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("idTipoMembresia");

                    b.ToTable("TipoMembresia");
                });

            modelBuilder.Entity("Fitzone.Entidades.Cuota", b =>
                {
                    b.HasOne("Fitzone.Entidades.Membresia", "Membresia")
                        .WithMany("Cuotas")
                        .HasForeignKey("idMembresia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Membresia");
                });

            modelBuilder.Entity("Fitzone.Entidades.Membresia", b =>
                {
                    b.HasOne("Fitzone.Entidades.EstadoMembresia", "EstadoMembresia")
                        .WithMany()
                        .HasForeignKey("idEstadoMembresia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fitzone.Entidades.Socio", "Socio")
                        .WithMany()
                        .HasForeignKey("idSocio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fitzone.Entidades.TipoMembresia", "TipoMembresia")
                        .WithMany()
                        .HasForeignKey("idTipoMembresia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstadoMembresia");

                    b.Navigation("Socio");

                    b.Navigation("TipoMembresia");
                });

            modelBuilder.Entity("Fitzone.Entidades.Socio", b =>
                {
                    b.HasOne("Fitzone.Entidades.Barrio", "Barrio")
                        .WithMany()
                        .HasForeignKey("idBarrio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Barrio");
                });

            modelBuilder.Entity("Fitzone.Entidades.Membresia", b =>
                {
                    b.Navigation("Cuotas");
                });
#pragma warning restore 612, 618
        }
    }
}
