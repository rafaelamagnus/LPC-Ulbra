﻿// <auto-generated />
using System;
using EfContaLuz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EfContaLuz.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<decimal>("kwGasto");

                    b.Property<int>("mediaConsumo");

                    b.Property<string>("nome");

                    b.Property<int>("numLeitura");

                    b.Property<decimal>("valorPagar");

                    b.HasKey("id");

                    b.ToTable("account");
                });
#pragma warning restore 612, 618
        }
    }
}
