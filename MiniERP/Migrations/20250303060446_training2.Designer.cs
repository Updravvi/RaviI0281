﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniERP.Context;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MiniERP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250303060446_training2")]
    partial class training2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MiniERP.Model.Customers", b =>
                {
                    b.Property<int>("CustomerNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CustomerNo"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PhoneNo")
                        .HasColumnType("integer");

                    b.HasKey("CustomerNo");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MiniERP.Model.Products", b =>
                {
                    b.Property<int>("ItemNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ItemNo"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int?>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("ItemNo");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MiniERP.Model.PurchaseOrder", b =>
                {
                    b.Property<int>("OrderNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderNo"));

                    b.Property<int>("ItemNo")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("VendorNo")
                        .HasColumnType("integer");

                    b.HasKey("OrderNo");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("MiniERP.Model.SalesOrder", b =>
                {
                    b.Property<int>("OrderNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderNo"));

                    b.Property<int>("ItemNo")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("VendorNo")
                        .HasColumnType("integer");

                    b.HasKey("OrderNo");

                    b.ToTable("SalesOrder");
                });

            modelBuilder.Entity("MiniERP.Model.Suppliers", b =>
                {
                    b.Property<int>("VendorNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("VendorNo"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("VendorNo");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("MiniERP.Model.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
