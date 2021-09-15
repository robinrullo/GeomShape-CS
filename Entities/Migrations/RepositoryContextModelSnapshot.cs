﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("GeomShape")
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Entities.Models.Drawing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Drawing");
                });

            modelBuilder.Entity("Entities.Models.Shape", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DrawingId")
                        .HasColumnType("char(36)");

                    b.Property<double>("OffsetX")
                        .HasColumnType("double");

                    b.Property<double>("OffsetY")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("DrawingId");

                    b.ToTable("Shape");
                });

            modelBuilder.Entity("Entities.Models.Circle", b =>
                {
                    b.HasBaseType("Entities.Models.Shape");

                    b.Property<float>("Radius")
                        .HasColumnType("float");

                    b.ToTable("Circle");
                });

            modelBuilder.Entity("Entities.Models.Rectangle", b =>
                {
                    b.HasBaseType("Entities.Models.Shape");

                    b.Property<float>("LengthA")
                        .HasColumnType("float");

                    b.Property<float>("LengthB")
                        .HasColumnType("float");

                    b.ToTable("Rectangle");
                });

            modelBuilder.Entity("Entities.Models.Triangle", b =>
                {
                    b.HasBaseType("Entities.Models.Shape");

                    b.Property<float>("LengthA")
                        .HasColumnType("float");

                    b.Property<float>("LengthB")
                        .HasColumnType("float");

                    b.Property<float>("LengthC")
                        .HasColumnType("float");

                    b.ToTable("Triangle");
                });

            modelBuilder.Entity("Entities.Models.Shape", b =>
                {
                    b.HasOne("Entities.Models.Drawing", null)
                        .WithMany("Shapes")
                        .HasForeignKey("DrawingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Circle", b =>
                {
                    b.HasOne("Entities.Models.Shape", null)
                        .WithOne()
                        .HasForeignKey("Entities.Models.Circle", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Rectangle", b =>
                {
                    b.HasOne("Entities.Models.Shape", null)
                        .WithOne()
                        .HasForeignKey("Entities.Models.Rectangle", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Triangle", b =>
                {
                    b.HasOne("Entities.Models.Shape", null)
                        .WithOne()
                        .HasForeignKey("Entities.Models.Triangle", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.Drawing", b =>
                {
                    b.Navigation("Shapes");
                });
#pragma warning restore 612, 618
        }
    }
}
