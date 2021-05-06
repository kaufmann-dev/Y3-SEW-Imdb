﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model.Configuration;

namespace Model.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20210506130355_NewMigrationAaa")]
    partial class NewMigrationAaa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Model.Entity.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MOVIE_ID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT")
                        .HasColumnName("DESCRIPTION");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("DIRECTOR");

                    b.Property<decimal>("Duration")
                        .HasColumnType("DECIMAL(4,0)")
                        .HasColumnName("DURATION");

                    b.Property<int>("Genre")
                        .HasColumnType("int")
                        .HasColumnName("GENRE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("NAME");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("RELEASE_DATE");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("SHORT_DESCRIPTION");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("MOVIES");
                });
#pragma warning restore 612, 618
        }
    }
}
