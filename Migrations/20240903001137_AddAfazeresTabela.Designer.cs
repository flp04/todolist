﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modulo.Data;

#nullable disable

namespace lista_afazeres.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240903001137_AddAfazeresTabela")]
    partial class AddAfazeresTabela
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Modulo.Entities.Afazer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ListaId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ListaId");

                    b.ToTable("Afazeres");
                });

            modelBuilder.Entity("Modulo.Entities.Lista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deleted_at")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Listas");
                });

            modelBuilder.Entity("Modulo.Entities.Afazer", b =>
                {
                    b.HasOne("Modulo.Entities.Lista", "Lista")
                        .WithMany("Afazeres")
                        .HasForeignKey("ListaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lista");
                });

            modelBuilder.Entity("Modulo.Entities.Lista", b =>
                {
                    b.Navigation("Afazeres");
                });
#pragma warning restore 612, 618
        }
    }
}
