﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chubbExamen.Data;

#nullable disable

namespace chubbExamen.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231021011202_personaSimpleDirection")]
    partial class personaSimpleDirection
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("chubbExamen.Models.tbl_Colonia", b =>
                {
                    b.Property<int>("IdColonia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdColonia"));

                    b.Property<string>("CP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdMunicipio")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("IdColonia");

                    b.HasIndex("IdMunicipio");

                    b.ToTable("tbl_Colonia");

                    b.HasData(
                        new
                        {
                            IdColonia = 1,
                            CP = "54680",
                            IdMunicipio = 1,
                            Nombre = "Centro",
                            status = true
                        },
                        new
                        {
                            IdColonia = 2,
                            CP = "54694",
                            IdMunicipio = 1,
                            Nombre = "Santa Teresa",
                            status = true
                        });
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Direccion", b =>
                {
                    b.Property<int>("IdDireccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDireccion"));

                    b.Property<string>("Calle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdColonia")
                        .HasColumnType("int");

                    b.Property<string>("NoExterior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoInterior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("IdDireccion");

                    b.HasIndex("IdColonia");

                    b.ToTable("tbl_Direccion");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Estado", b =>
                {
                    b.Property<int>("IdEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstado"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("IdEstado");

                    b.ToTable("tbl_Estado");

                    b.HasData(
                        new
                        {
                            IdEstado = 1,
                            Nombre = "Estado de México",
                            status = true
                        });
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Municipio", b =>
                {
                    b.Property<int>("IdMunicipio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMunicipio"));

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("IdMunicipio");

                    b.HasIndex("IdEstado");

                    b.ToTable("tbl_Municipio");

                    b.HasData(
                        new
                        {
                            IdMunicipio = 1,
                            IdEstado = 1,
                            Nombre = "Huehuetoca",
                            status = true
                        },
                        new
                        {
                            IdMunicipio = 2,
                            IdEstado = 1,
                            Nombre = "Coyotepec",
                            status = true
                        });
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Persona", b =>
                {
                    b.Property<int>("IdPersona")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPersona"));

                    b.Property<string>("Amaterno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apaterno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int?>("tbl_DireccionIdDireccion")
                        .HasColumnType("int");

                    b.HasKey("IdPersona");

                    b.HasIndex("tbl_DireccionIdDireccion");

                    b.ToTable("tbl_Persona");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Colonia", b =>
                {
                    b.HasOne("chubbExamen.Models.tbl_Municipio", "Municipio")
                        .WithMany("Colonias")
                        .HasForeignKey("IdMunicipio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Direccion", b =>
                {
                    b.HasOne("chubbExamen.Models.tbl_Colonia", "Colonia")
                        .WithMany("Direcciones")
                        .HasForeignKey("IdColonia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colonia");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Municipio", b =>
                {
                    b.HasOne("chubbExamen.Models.tbl_Estado", "Estado")
                        .WithMany("Municipios")
                        .HasForeignKey("IdEstado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Persona", b =>
                {
                    b.HasOne("chubbExamen.Models.tbl_Direccion", null)
                        .WithMany("Personas")
                        .HasForeignKey("tbl_DireccionIdDireccion");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Colonia", b =>
                {
                    b.Navigation("Direcciones");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Direccion", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Estado", b =>
                {
                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("chubbExamen.Models.tbl_Municipio", b =>
                {
                    b.Navigation("Colonias");
                });
#pragma warning restore 612, 618
        }
    }
}
