﻿// <auto-generated />
using System;
using EfContaLuz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EfContaLuz.Repository.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191109062930_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EfContaLuz.Models.Conta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("dataPagamento");

                    b.Property<int?>("imovelid");

                    b.Property<decimal>("kwGasto");

                    b.Property<int>("mediaConsumo");

                    b.Property<string>("nome");

                    b.Property<int>("numLeitura");

                    b.Property<decimal>("valorPagar");

                    b.HasKey("id");

                    b.HasIndex("imovelid");

                    b.ToTable("account");
                });

            modelBuilder.Entity("EfContaLuz.Models.Imovel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cidade");

                    b.Property<string>("descricao");

                    b.Property<string>("estado");

                    b.Property<int>("numero");

                    b.HasKey("id");

                    b.ToTable("immobile");
                });

            modelBuilder.Entity("EfContaLuz.Models.Conta", b =>
                {
                    b.HasOne("EfContaLuz.Models.Imovel", "imovel")
                        .WithMany()
                        .HasForeignKey("imovelid");
                });
#pragma warning restore 612, 618
        }
    }
}