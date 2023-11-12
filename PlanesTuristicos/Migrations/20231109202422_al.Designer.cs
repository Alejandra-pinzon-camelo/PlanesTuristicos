﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlanesTuristicos.Models;

#nullable disable

namespace PlanesTuristicos.Migrations
{
    [DbContext(typeof(PlanesTuristicosContext))]
    [Migration("20231109202422_al")]
    partial class al
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlanesTuristicos.Models.PlanesT", b =>
                {
                    b.Property<int>("Id_PlanTuristicos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_PlanTuristicos"));

                    b.Property<int?>("Actividades")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasColumnName("Actividades");

                    b.Property<string>("Duracion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Duracion");

                    b.Property<string>("Informacion")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Informacion");

                    b.Property<string>("Municipio")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Municipio");

                    b.Property<string>("Nombre_PlanTuristico")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombre_PlanTuristico");

                    b.Property<double>("Precio")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("float")
                        .HasColumnName("Precio");

                    b.Property<int?>("Rut")
                        .HasColumnType("int")
                        .HasColumnName("Rut");

                    b.HasKey("Id_PlanTuristicos")
                        .HasName("PK__PlanesT__Id");

                    b.ToTable("PlanesT", (string)null);
                });

            modelBuilder.Entity("PlanesTuristicos.Models.Proveedor", b =>
                {
                    b.Property<int>("Id_Proveedor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Proveedor"));

                    b.Property<int?>("Cedula")
                        .HasColumnType("int")
                        .HasColumnName("cedula");

                    b.Property<string>("Clave")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<int?>("Rut")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("int")
                        .HasColumnName("Rut");

                    b.Property<string>("direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccion");

                    b.Property<string>("nombreProveedor")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombre_turista");

                    b.HasKey("Id_Proveedor")
                        .HasName("PK__Proveedores__Id");

                    b.ToTable("Proveedor", (string)null);
                });

            modelBuilder.Entity("PlanesTuristicos.Models.Turista", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<int?>("Cedula")
                        .HasColumnType("int")
                        .HasColumnName("cedula");

                    b.Property<string>("Clave")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Correo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("correo");

                    b.Property<string>("Direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("direccion");

                    b.Property<string>("NombreTurista")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombre_turista");

                    b.Property<int?>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("IdUsuario")
                        .HasName("PK__Usuario__5B65BF971AB28277");

                    b.ToTable("Usuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
