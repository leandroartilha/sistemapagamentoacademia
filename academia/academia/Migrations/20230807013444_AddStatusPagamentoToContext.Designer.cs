﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using academia.Contexto;

#nullable disable

namespace academia.Migrations
{
    [DbContext(typeof(AcademiaDbContext))]
    [Migration("20230807013444_AddStatusPagamentoToContext")]
    partial class AddStatusPagamentoToContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("academia.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DataMensalidade")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Inativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("StatusPagamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal?>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("StatusPagamentoId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("academia.Models.StatusPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeStatusPagamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusPagamento");
                });

            modelBuilder.Entity("academia.Models.teste", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("teste");
                });

            modelBuilder.Entity("academia.Models.Aluno", b =>
                {
                    b.HasOne("academia.Models.StatusPagamento", "StatusPagamento")
                        .WithMany("Aluno")
                        .HasForeignKey("StatusPagamentoId");

                    b.Navigation("StatusPagamento");
                });

            modelBuilder.Entity("academia.Models.StatusPagamento", b =>
                {
                    b.Navigation("Aluno");
                });
#pragma warning restore 612, 618
        }
    }
}
