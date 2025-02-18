﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project02_EF_ASP.NET_MVC.Data;

namespace Project02_EF_ASP.NET_MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605093433_seedCars")]
    partial class seedCars
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<int?>("StoreId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("text");

                    b.Property<string>("color")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("StoreId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Manufacturer = "Ford",
                            Model = "V90",
                            StoreId = 2,
                            Type = "Coupe",
                            color = "silver"
                        },
                        new
                        {
                            Id = 2,
                            Manufacturer = "Ferrari",
                            Model = "Silverado",
                            StoreId = 2,
                            Type = "SUV",
                            color = "indigo"
                        },
                        new
                        {
                            Id = 3,
                            Manufacturer = "BMW",
                            Model = "A8",
                            StoreId = 1,
                            Type = "SUV",
                            color = "orange"
                        },
                        new
                        {
                            Id = 4,
                            Manufacturer = "Lamborghini",
                            Model = "Beetle",
                            StoreId = 1,
                            Type = "Coupe",
                            color = "magenta"
                        },
                        new
                        {
                            Id = 5,
                            Manufacturer = "Tesla",
                            Model = "Land Cruiser",
                            StoreId = 1,
                            Type = "Hatchback",
                            color = "grey"
                        },
                        new
                        {
                            Id = 6,
                            Manufacturer = "Dodge",
                            Model = "Challenger",
                            StoreId = 1,
                            Type = "Coupe",
                            color = "fuchsia"
                        },
                        new
                        {
                            Id = 7,
                            Manufacturer = "BMW",
                            Model = "CTS",
                            StoreId = 2,
                            Type = "Cargo Van",
                            color = "lime"
                        },
                        new
                        {
                            Id = 8,
                            Manufacturer = "Fiat",
                            Model = "Silverado",
                            StoreId = 1,
                            Type = "Wagon",
                            color = "black"
                        },
                        new
                        {
                            Id = 9,
                            Manufacturer = "Toyota",
                            Model = "F-150",
                            StoreId = 1,
                            Type = "Coupe",
                            color = "red"
                        },
                        new
                        {
                            Id = 10,
                            Manufacturer = "Smart",
                            Model = "Mustang",
                            StoreId = 1,
                            Type = "Passenger Van",
                            color = "silver"
                        });
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CarId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.StoreModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Jeddah",
                            Name = "Store 1"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Riyadh",
                            Name = "Store 2"
                        });
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CarModel", b =>
                {
                    b.HasOne("Project02_EF_ASP.NET_MVC.Models.StoreModel", "Store")
                        .WithMany("Cars")
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CustomerModel", b =>
                {
                    b.HasOne("Project02_EF_ASP.NET_MVC.Models.CarModel", "Car")
                        .WithOne("Customer")
                        .HasForeignKey("Project02_EF_ASP.NET_MVC.Models.CustomerModel", "CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
