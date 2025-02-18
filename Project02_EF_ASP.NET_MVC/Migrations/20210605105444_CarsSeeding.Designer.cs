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
    [Migration("20210605105444_CarsSeeding")]
    partial class CarsSeeding
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

                    b.Property<int?>("CategoryID")
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

                    b.HasIndex("CategoryID");

                    b.HasIndex("StoreId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryID = 2,
                            Manufacturer = "Land Rover",
                            Model = "CX-9",
                            StoreId = 2,
                            Type = "Extended Cab Pickup",
                            color = "white"
                        },
                        new
                        {
                            Id = 2,
                            CategoryID = 1,
                            Manufacturer = "Tesla",
                            Model = "XC90",
                            StoreId = 1,
                            Type = "Passenger Van",
                            color = "salmon"
                        },
                        new
                        {
                            Id = 3,
                            CategoryID = 2,
                            Manufacturer = "Volvo",
                            Model = "El Camino",
                            StoreId = 2,
                            Type = "Convertible",
                            color = "lavender"
                        },
                        new
                        {
                            Id = 4,
                            CategoryID = 1,
                            Manufacturer = "Mercedes Benz",
                            Model = "V90",
                            StoreId = 1,
                            Type = "Crew Cab Pickup",
                            color = "cyan"
                        },
                        new
                        {
                            Id = 5,
                            CategoryID = 1,
                            Manufacturer = "Nissan",
                            Model = "Camaro",
                            StoreId = 1,
                            Type = "Minivan",
                            color = "maroon"
                        },
                        new
                        {
                            Id = 6,
                            CategoryID = 3,
                            Manufacturer = "Jaguar",
                            Model = "F-150",
                            StoreId = 1,
                            Type = "SUV",
                            color = "teal"
                        },
                        new
                        {
                            Id = 7,
                            CategoryID = 2,
                            Manufacturer = "Chevrolet",
                            Model = "Fortwo",
                            StoreId = 2,
                            Type = "Wagon",
                            color = "orange"
                        },
                        new
                        {
                            Id = 8,
                            CategoryID = 2,
                            Manufacturer = "Toyota",
                            Model = "Durango",
                            StoreId = 1,
                            Type = "SUV",
                            color = "orchid"
                        },
                        new
                        {
                            Id = 9,
                            CategoryID = 2,
                            Manufacturer = "Tesla",
                            Model = "PT Cruiser",
                            StoreId = 1,
                            Type = "Wagon",
                            color = "violet"
                        },
                        new
                        {
                            Id = 10,
                            CategoryID = 1,
                            Manufacturer = "Mercedes Benz",
                            Model = "Civic",
                            StoreId = 2,
                            Type = "Wagon",
                            color = "mint green"
                        },
                        new
                        {
                            Id = 11,
                            CategoryID = 3,
                            Manufacturer = "Audi",
                            Model = "Grand Caravan",
                            StoreId = 1,
                            Type = "Hatchback",
                            color = "olive"
                        },
                        new
                        {
                            Id = 12,
                            CategoryID = 3,
                            Manufacturer = "Ford",
                            Model = "Beetle",
                            StoreId = 2,
                            Type = "Sedan",
                            color = "black"
                        },
                        new
                        {
                            Id = 13,
                            CategoryID = 2,
                            Manufacturer = "Land Rover",
                            Model = "ATS",
                            StoreId = 2,
                            Type = "Cargo Van",
                            color = "ivory"
                        },
                        new
                        {
                            Id = 14,
                            CategoryID = 1,
                            Manufacturer = "Hyundai",
                            Model = "F-150",
                            StoreId = 2,
                            Type = "SUV",
                            color = "teal"
                        },
                        new
                        {
                            Id = 15,
                            CategoryID = 3,
                            Manufacturer = "Bentley",
                            Model = "Focus",
                            StoreId = 2,
                            Type = "Wagon",
                            color = "white"
                        },
                        new
                        {
                            Id = 16,
                            CategoryID = 2,
                            Manufacturer = "Tesla",
                            Model = "Focus",
                            StoreId = 1,
                            Type = "Extended Cab Pickup",
                            color = "magenta"
                        },
                        new
                        {
                            Id = 17,
                            CategoryID = 3,
                            Manufacturer = "Audi",
                            Model = "Silverado",
                            StoreId = 1,
                            Type = "Extended Cab Pickup",
                            color = "fuchsia"
                        },
                        new
                        {
                            Id = 18,
                            CategoryID = 3,
                            Manufacturer = "Lamborghini",
                            Model = "Prius",
                            StoreId = 2,
                            Type = "Passenger Van",
                            color = "blue"
                        },
                        new
                        {
                            Id = 19,
                            CategoryID = 2,
                            Manufacturer = "Hyundai",
                            Model = "1",
                            StoreId = 2,
                            Type = "Passenger Van",
                            color = "violet"
                        },
                        new
                        {
                            Id = 20,
                            CategoryID = 1,
                            Manufacturer = "Kia",
                            Model = "Countach",
                            StoreId = 2,
                            Type = "Wagon",
                            color = "violet"
                        },
                        new
                        {
                            Id = 21,
                            CategoryID = 3,
                            Manufacturer = "Volkswagen",
                            Model = "F-150",
                            StoreId = 1,
                            Type = "Coupe",
                            color = "blue"
                        },
                        new
                        {
                            Id = 22,
                            CategoryID = 3,
                            Manufacturer = "Jeep",
                            Model = "Countach",
                            StoreId = 2,
                            Type = "Cargo Van",
                            color = "magenta"
                        },
                        new
                        {
                            Id = 23,
                            CategoryID = 3,
                            Manufacturer = "Cadillac",
                            Model = "Model S",
                            StoreId = 2,
                            Type = "Sedan",
                            color = "yellow"
                        },
                        new
                        {
                            Id = 24,
                            CategoryID = 2,
                            Manufacturer = "Fiat",
                            Model = "Fiesta",
                            StoreId = 2,
                            Type = "Convertible",
                            color = "purple"
                        },
                        new
                        {
                            Id = 25,
                            CategoryID = 2,
                            Manufacturer = "Bentley",
                            Model = "Challenger",
                            StoreId = 1,
                            Type = "Coupe",
                            color = "red"
                        });
                });

            modelBuilder.Entity("Project02_EF_ASP.NET_MVC.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electric"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gasoline"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Diesel"
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
                    b.HasOne("Project02_EF_ASP.NET_MVC.Models.CategoryModel", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryID");

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
