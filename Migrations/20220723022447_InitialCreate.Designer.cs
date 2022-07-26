﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using projectEF;

#nullable disable

namespace projectEF.Migrations
{
    [DbContext(typeof(TareasContext))]
    [Migration("20220723022447_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("projectEF.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria", (string)null);
                });

            modelBuilder.Entity("projectEF.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoriaID")
                        .HasColumnType("uuid");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("integer");

                    b.Property<Guid?>("TareaID1")
                        .HasColumnType("uuid");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("TareaID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("TareaID1");

                    b.ToTable("Tarea", (string)null);
                });

            modelBuilder.Entity("projectEF.Models.Tarea", b =>
                {
                    b.HasOne("projectEF.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projectEF.Models.Tarea", null)
                        .WithMany("Tareas")
                        .HasForeignKey("TareaID1");

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("projectEF.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });

            modelBuilder.Entity("projectEF.Models.Tarea", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
