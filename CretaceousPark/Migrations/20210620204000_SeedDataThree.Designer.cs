﻿// <auto-generated />
using CretaceousPark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CretaceousPark.Migrations
{
    [DbContext(typeof(CretaceousParkContext))]
    [Migration("20210620204000_SeedDataThree")]
    partial class SeedDataThree
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CretaceousPark.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 7,
                            Age = 7,
                            Gender = "Female",
                            Name = "Matilda",
                            Species = "Woolly Mammoth"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 10,
                            Gender = "Female",
                            Name = "Rexie",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 2,
                            Gender = "Female",
                            Name = "Matilda",
                            Species = "Dinosaur"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 4,
                            Gender = "Male",
                            Name = "Pip",
                            Species = "Shark"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 22,
                            Gender = "Male",
                            Name = "Bartholomew",
                            Species = "Dinosaur"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}