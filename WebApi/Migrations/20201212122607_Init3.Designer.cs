﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Models;

namespace WebApi.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20201212122607_Init3")]
    partial class Init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebApi.Models.Beer", b =>
                {
                    b.Property<int>("BeerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BeerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BreweryBeerId")
                        .HasColumnType("int");

                    b.Property<string>("BreweryBeerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BreweryId")
                        .HasColumnType("int");

                    b.Property<double>("Degree")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("WholesalerBeerId")
                        .HasColumnType("int");

                    b.Property<string>("WholesalerBeerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WholesalerId")
                        .HasColumnType("int");

                    b.HasKey("BeerId");

                    b.HasIndex("BreweryId");

                    b.HasIndex("WholesalerId");

                    b.ToTable("Beers");
                });

            modelBuilder.Entity("WebApi.Models.Brewery", b =>
                {
                    b.Property<int>("BreweryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BreweryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BreweryId");

                    b.ToTable("Breweries");
                });

            modelBuilder.Entity("WebApi.Models.Wholesaler", b =>
                {
                    b.Property<int>("WholesalerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("WholesalerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WholesalerId");

                    b.ToTable("Wholesalers");
                });

            modelBuilder.Entity("WebApi.Models.Beer", b =>
                {
                    b.HasOne("WebApi.Models.Brewery", null)
                        .WithMany("BBeersList")
                        .HasForeignKey("BreweryId");

                    b.HasOne("WebApi.Models.Wholesaler", null)
                        .WithMany("WBeersList")
                        .HasForeignKey("WholesalerId");
                });

            modelBuilder.Entity("WebApi.Models.Brewery", b =>
                {
                    b.Navigation("BBeersList");
                });

            modelBuilder.Entity("WebApi.Models.Wholesaler", b =>
                {
                    b.Navigation("WBeersList");
                });
#pragma warning restore 612, 618
        }
    }
}
