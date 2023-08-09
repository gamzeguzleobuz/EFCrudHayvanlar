﻿// <auto-generated />
using EfCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCrud.Data.Migrations
{
    [DbContext(typeof(HayvanContext))]
    [Migration("20230809071240_seed")]
    partial class seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfCrud.Data.Hayvan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Hayvanlar");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Kedi"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Köpek"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Aslan"
                        },
                        new
                        {
                            Id = 4,
                            Ad = "Kuş"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}