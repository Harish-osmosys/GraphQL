﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using graphql_demo.Data;

#nullable disable

namespace graphql_demo.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20231226012457_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("graphql_demo.Entities.ProductDetails", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("ProductName")
                        .HasColumnType("longtext");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("int");

                    b.Property<int>("ProductStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11df7fe0-36bb-4038-a8e8-f8fa1d64f136"),
                            ProductDescription = "IPhone 14",
                            ProductName = "IPhone",
                            ProductPrice = 120000,
                            ProductStock = 100
                        },
                        new
                        {
                            Id = new Guid("f0e2b908-7f8b-4bd9-8e01-d263ec506dca"),
                            ProductDescription = "Smart TV",
                            ProductName = "Samsung TV",
                            ProductPrice = 400000,
                            ProductStock = 120
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
